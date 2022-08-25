using System;
using System.ComponentModel.Design;

namespace RefactoringExamples.ReplaceInheritance
{
    public class StatisticGatherClassRefactored
    {
        private string url;

        public StatisticGatherClassRefactored(string url)
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
    
    
    public class BusinessClassRefactored
    {
        private readonly StatisticGatherClassRefactored _logger;

        public BusinessClassRefactored(StatisticGatherClassRefactored logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.SendLog("log");
            //do smth
        }
    }
}