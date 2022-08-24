using System;
using System.Xml.Linq;

namespace RefactoringExamples.CollapseHierarchy
{
    public class BaseJob
    {
        public void Execute()
        {
            SaveData();
        }

        protected virtual void SaveData()
        {
            //saving
        }
    }

    public class SimpleJob : BaseJob
    {
        protected override void SaveData()
        {
            Console.WriteLine("logging");
            
            base.SaveData();
        }
    }


    public class Test
    {
        public void TM()
        {
            SimpleJob simpleJob = new SimpleJob();
            BaseJob baseJob = new BaseJob();
            
            simpleJob.Execute();
            
            baseJob.Execute();
        }
    }
}