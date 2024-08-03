using FileSearch.Application.Service;
using FileSearch.Domain.Folder;

namespace DirectoryBackup.Application.Services;

public class BackupToDirectory(FindFolderByType findFolderByType)
{
    public void Backup()
    {
        var modsDirectory = findFolderByType.Find(FolderTypeEnum.Mods);
        var savesDirectory = findFolderByType.Find(FolderTypeEnum.Saves);
    }
}