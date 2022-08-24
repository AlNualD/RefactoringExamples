namespace RefactoringExamples.ConstructorToFactoryMethod
{
    public enum Type
    {
        Summation,
        SelfSummation,
        Subtraction,
        Multiplication,
        Division,
        Square,
        SuperOperation
    }
    public class MathOperation
    {
        private Type _type;
        private int _helper = 0;
        private SuperSummator _delegate;
        
        public MathOperation(Type type)
        {
            _type = type;
            switch (type)
            {
                case Type.SuperOperation: _helper = 23;
                    _delegate = new SuperSummator();
                    break;
            }
            
        }

        public int DoOperation(int a, int b)
        {
            switch (_type)
            {
                
            }

            return 0;
        }
    }

    public class SuperSummator
    {
        
    }
}