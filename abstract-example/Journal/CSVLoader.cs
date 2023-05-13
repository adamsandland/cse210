using System;
using System.IO;
public class CSVLoader{
        
    private List<Entry> _EntriesInFile=new List<Entry>();
    StreamReader reader = null;
    StreamWriter writer = null;

    public void load(string filePath){
        reader= new StreamReader(File.OpenRead(filePath));
        while (!reader.EndOfStream){
            List<string> _fileLine = new List<string>();
            var line = reader.ReadLine();
            var values = line.Split(',');
            foreach (var item in values){
               _fileLine.Add(item);
            }
            _EntriesInFile.Add(new Entry(_fileLine[0],_fileLine[1]));
        }
        reader.Close();
    }
    public void overwrite(string filePath, List<Entry> OverwritingEntries){
        _EntriesInFile = OverwritingEntries;
        writer = new StreamWriter(File.OpenWrite(filePath));
        foreach (Entry item in _EntriesInFile){
            writer.WriteLine($"{item.GetDate()},{item.GetUserEntry()}");
        }
        writer.Close();
    }
    public List<Entry> ReturnContents(){
        return _EntriesInFile;
    }
}