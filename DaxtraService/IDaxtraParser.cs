namespace Evolution.Daxtra
{
    using Evolution.Daxtra.Models;
    using System.Threading.Tasks;

    public interface IDaxtraParser
    {
        Task<Resume> Parse(byte[] file);
    }
}