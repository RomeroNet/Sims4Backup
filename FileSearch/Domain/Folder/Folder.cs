namespace FileSearch.Domain.Folder;

public class Folder(string path)
{
    public string Path { get; private set; } = path;
}