using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Wells Fargo";
        job1._jobTitle = "Data Engineer";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Mountain America";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2017;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Leonardo Alvarino";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);    

        myResume.Display();
    }
}