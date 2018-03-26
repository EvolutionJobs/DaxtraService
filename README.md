# DaxtraService
.NET Core service to send CVs to Datxra's service. 

See [Daxtra's API documentation here](http://cvxdemo.daxtra.com/cvx/).

Daxtra provide a [reference .NET implementation](http://cvxdemo.daxtra.com/cvx/download/CVXtractorService.cs), 
but this is compatible with .NET Core's dependency injection model.

This also serialises the result to .NET structured objects, see [Model](DaxtraService/Models).

## Startup Injection

To add this service:

``` c#
string url = $"https://{yourService}.daxtra.com";
string api = "/cvx/rest/api/v1"; // Or whatever version you want to use
string key = "your secret password";

services.AddDaxtraParser(url, api, key);
```

## Using the CV Parsing Service

Then this service is available as `IDaxtraParser`, for instance as a Web API action:

``` c#
[HttpPost("parseCV")]
public async Task<IEnumerable<Resume>> ParseCV(
    [FromServices] IDaxtraParser parser,     // Get the parser from the injected services 
    [FromForm] IEnumerable<IFormFile> files) // CV files posted from an HTML form
{
    var result = new List<Resume>();
    foreach (var f in files)
    {
        if (f.Length == 0)
             continue;

        using (var s = new MemoryStream())
        {
            await f.CopyToAsync(s);
            var parsed = await parser.Parse(s.ToArray());
            result.Add(parsed);
        }
    }

    return result;
}
```

## Exceptions

Any errors are thrown as [`DaxtraException`](/DaxtraService/Models/DaxtraException.cs), and this contains the body of the `CSERROR` from the Daxtra service and the HTTP Status.

## Request Details

Requests to the Daxtra service are sent as `multipart/form-data` and GZIP compression, as per [best practice recommendation](http://cvxdemo.daxtra.com/cvx/#integration-rest). Content are send and parsed as JSON.

# Roadmap

Currently only the profile service to parse CVs is supported. We plan to introduce batch parsing next.
