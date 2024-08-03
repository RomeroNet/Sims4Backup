using DirectoryBackup.Domain;
using FileSearch.Domain.Folder;

namespace DirectoryBackup.Infrastructure.Repository;

public class FilesystemDirectoryDataBackup : IDirectoryDataBackup
{
    private const string Separator = @"\";
    
    public void Backup(Folder origin, string destination)
    {
        if (!Directory.Exists(destination))
        {
            Directory.CreateDirectory(destination);
        }
        
        CopyDirectoryRecursively(origin, destination);
    }

    private void CopyDirectoryRecursively(Folder origin, string destination)
    {
        var destinationSubdirectory = origin.Path.Split(Separator).Last();
        
        Directory.CreateDirectory($@"{destination}\{destinationSubdirectory}");
    }
}