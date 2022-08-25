using System;
using System.ComponentModel.Design;

namespace RefactoringExamples.ReplaceInheritance
{
    public class StatisticGatherClass
    {
        private string url;

        public StatisticGatherClass(string url)
        {
            this.url = url;
        }


        public void SendLog(string msg)
        {
            Console.Out.WriteLine(msg);
        }

        public void SendMetric(int metric, string timestamp)
        {
            Console.WriteLine($"{timestamp}: {metric}");
        }

        public void SendError(string err)
        {
            Console.WriteLine("Err");
            
            SendLog(err);
        }
    }
    
    
    public class BusinessClass : StatisticGatherClass
    {
        public BusinessClass(string url) : base(url)
        {
        }

        public void DoWork()
        {
            SendLog("log");
            //smth
        }
    }
}