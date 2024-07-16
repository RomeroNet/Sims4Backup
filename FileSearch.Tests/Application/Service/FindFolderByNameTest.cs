using FileSearch.Application.Service;
using FileSearch.Domain.Folder;
using Moq;

namespace FileSearch.Tests.Application.Service;

public class FindFolderByNameTest
{
    [Fact]
    public void ItShouldFindFolderByName()
    {
        var repositoryMock = new Mock<IFolderRepository>();

        var folder = new Folder("");

        repositoryMock.Setup(repository => repository.GetFolderByType(FolderTypeEnum.MODS)).Returns(folder);

        var service = new FindFolderByType(repositoryMock.Object);

        var result = service.Find(FolderTypeEnum.MODS);
        
        Assert.Same(folder, result);
    }
}