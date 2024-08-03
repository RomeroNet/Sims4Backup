using FileSearch.Domain.Folder;

namespace DirectoryBackup.Domain;

public interface IDirectoryDataBackup
{
    public void Backup(Folder origin, string destination);
}