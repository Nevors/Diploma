interface IValueProvider{
    File GetFile(string fileName);
    List<File> GetFiles(TypeFile type);
}