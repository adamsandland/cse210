using System;

public class Job
{
    private string _company="";
    private string _jobTitle="";
    private int _startYear=0;
    private int _endYear=0;
    public Job(string company, string jobTitle, int startYear, int endYear){
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }
    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}