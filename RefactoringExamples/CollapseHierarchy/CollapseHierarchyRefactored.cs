using System;
using System.Xml.Linq;

namespace RefactoringExamples.CollapseHierarchy
{
    public class BaseJobRefactored
    {
        public void Execute()
        {
            SaveData();
        }

        private void SaveData()
        {
            Console.WriteLine("logging");

            //saving
        }
    }

    public class SimpleJobRefactored : BaseJobRefactored
    {

    }


    public class TestRefactored
    {
        public void TM()
        {
            SimpleJobRefactored simpleJob = new SimpleJobRefactored();
            BaseJobRefactored baseJob = new BaseJobRefactored();
            
            simpleJob.Execute();
            
            baseJob.Execute();
        }
    }
}