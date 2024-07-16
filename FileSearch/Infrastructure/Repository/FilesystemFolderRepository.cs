using System.ComponentModel;
using FileSearch.Domain.Folder;

namespace FileSearch.Infrastructure.Repository;

public class FilesystemFolderRepository : IFolderRepository
{
    private const string ElectronicArtsFolder = @"\Electronic Arts";
    private const string GameFolderSearchPattern = @"*Sims 4";
    private const string ModsFolder = @"\Mods";
    private const string SavesFolder = @"\saves";

    public Folder GetFolderByType(FolderTypeEnum type) => type switch
    {
        FolderTypeEnum.MODS => new Folder(GetGamePath() + ModsFolder),
        FolderTypeEnum.SAVES => new Folder(GetGamePath() + SavesFolder),
        _ => throw new InvalidEnumArgumentException()
    };

    private static string GetGamePath()
    {
        var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ElectronicArtsFolder;
        var subFolders = Directory.GetDirectories(documentsPath, GameFolderSearchPattern);

        return subFolders[0];
    }
}