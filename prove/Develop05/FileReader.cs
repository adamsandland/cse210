public class FileReader{
    string _fileName;
    string[] _lines;
    public FileReader(string textFile){
        _fileName = textFile;
        _lines = File.ReadAllLines($"{_fileName}");
    }
    public List<string> GetFile(){ return _lines.ToList<string>(); }
}