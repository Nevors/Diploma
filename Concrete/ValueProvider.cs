class ValueProvider : IValueProvider{

    Dictionary<TypeFile,Dictionary<string,file>> files;

    public void AddFile(File file){
        Dictionary<string,file> dic;
        if(!files.ContainsKey(file.TypeFile)){
            dic = new Dictionary<string,file>;
            files.Add(file.TypeFile, dic);
        }else{
            dic = files[file.TypeFile];
        }
        dic.Add(file.FileName,file);
    }

    public File GetFile(string fileName){
        foreach (var item in files.Values)
        {
            if(item.ContainsKey(fileName)){
                return item[fileName];
            }
        }
        return null;
    }
    public List<File> GetFiles(TypeFile type){
        if(files.ContainsKey(type)){
            return files[type].Values;
        }
        return new List<File>();
    }
}