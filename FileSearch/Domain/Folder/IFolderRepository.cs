namespace FileSearch.Domain.Folder;

public interface IFolderRepository
{
    public Folder GetFolderByType(FolderTypeEnum type);
}