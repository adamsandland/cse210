using System;
using System.IO;

public class TextReader{
    
    private StreamReader reader = null;
    private string _reference;
    private string _scripture;
    public TextReader(string fileName){
        reader= new StreamReader(File.OpenRead(fileName));
        while (!reader.EndOfStream){
            List<string> _fileLine = new List<string>();
            var line = reader.ReadLine();
            var values = line.Split("|||");
            foreach (var item in values){
               _fileLine.Add(item);
            }
            _reference = _fileLine[0];
            _scripture = _fileLine[1];
        }
        reader.Close();
    }
    public string GetRef(){return _reference;}
    public string GetScript(){return _scripture;}
}