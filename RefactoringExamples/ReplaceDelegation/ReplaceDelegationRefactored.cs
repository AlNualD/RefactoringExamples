using System;

namespace RefactoringExamples.ReplaceDelegation
{
    public class SpecialCrewRefactored : CrewRefactored
    {
        public void MethodB1()
        {
            Console.Out.WriteLine("BBB111");
            Method1();
        }

        public void SpecialWork()
        {
            //wokr
            var count = Counter;
        }
    }

    public class CrewRefactored
    {
        protected int Counter { get; }

        public CrewRefactored()
        {
            Counter = 0;
        }
        
        public void Method1()
        {
            Console.Out.WriteLine("111111");
        }
    }
}