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

    public class TestRefactored
    {
        public void TM()
        {
            BaseJobRefactored baseJob = new BaseJobRefactored();
            
            baseJob.Execute();
        }
    }
}