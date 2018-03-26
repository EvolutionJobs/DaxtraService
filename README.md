# DaxtraService
.NET Core service to send CVs to Datxra's service. 

See [Daxtra's API documentation here](http://cvxdemo.daxtra.com/cvx/).

Daxtra provide a [reference .NET implementation](http://cvxdemo.daxtra.com/cvx/download/CVXtractorService.cs), 
but this is compatible with .NET Core's dependency injection model.

This also serialises the result to .NET structured objects, see [Model](DaxtraService/Models).

## Startup Injection

To add this service:

``` c#
string ur = $"https://{yourService}.daxtra.com";
string api = "/cvx/rest/api/v1"; // Or whatever version you want to use
string key = "your secret password";

services.AddDaxtraParser(url, api, key);
```

Then this service is available as `IDaxtraParser`.
