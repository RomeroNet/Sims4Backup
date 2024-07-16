using FileSearch.Domain.Folder;

namespace FileSearch.Application.Service;

public class FindFolderByType(IFolderRepository folderRepository)
{
    public Folder Find(FolderTypeEnum type)
    {
        return folderRepository.GetFolderByType(type);
    }
}