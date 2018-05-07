class ValueProvider : IValueProvider{

    Dictionary<TypeFile,List<Dictionary<string,file>> files;

    File GetFile(string fileName){
        foreach (var item in files.Values)
        {
            if(item.ContainsKey(fileName)){
                return item[fileName];
            }
        }
        return null;
    }
    List<File> GetFiles(TypeFile type){
        if(files.ContainsKey(type)){
            return files[type].Values;
        }
        return new List<File>();
    }
}