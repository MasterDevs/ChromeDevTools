using System.IO;

namespace MasterDevs.ChromeDevTools
{
    public interface IDirectoryCleaner
    {
        void Delete(DirectoryInfo dir);
    }
}