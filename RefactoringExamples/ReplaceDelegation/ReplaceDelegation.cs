using System;

namespace RefactoringExamples.ReplaceDelegation
{
    public class SpecialCrew
    {
        private readonly Crew _crew = new Crew();

        public int GetCounter()
        {
            return _crew.counter;
        }

        public void MethodB1()
        {
            Console.Out.WriteLine("BBB111");
            _crew.Method1();
        }

        public void SpecialWork()
        {
            //wokr
            var count = _crew.counter;
        }
    }

    public class Crew
    {
        public int counter { get; }

        public Crew()
        {
            counter = 0;
        }
        
        public void Method1()
        {
            Console.Out.WriteLine("111111");
        }
        
        
        
    }
}