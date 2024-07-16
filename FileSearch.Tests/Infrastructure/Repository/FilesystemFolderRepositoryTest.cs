using FileSearch.Domain.Folder;
using FileSearch.Infrastructure.Repository;

namespace FileSearch.Tests.Infrastructure.Repository;

public class FilesystemFolderRepositoryTest
{
    [Fact]
    public void ItShouldReturnModsFolder()
    {
        var repository = new FilesystemFolderRepository();

        var result = repository.GetFolderByType(FolderTypeEnum.MODS);

        Assert.Equal(@"C:\Users\frome\Documents\Electronic Arts\Los Sims 4\Mods", result.Path);
    }
    
    [Fact]
    public void ItShouldReturnSavesFolder()
    {
        var repository = new FilesystemFolderRepository();

        var result = repository.GetFolderByType(FolderTypeEnum.SAVES);

        Assert.Equal(@"C:\Users\frome\Documents\Electronic Arts\Los Sims 4\saves", result.Path);
    }
}