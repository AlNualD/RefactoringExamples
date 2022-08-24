namespace RefactoringExamples.ConstructorToFactoryMethod
{
    public class MathOperationRefactored
    {
        private Type _type;
        private int _helper = 0;

        protected MathOperationRefactored(Type type)
        {
            _type = type;

            
        }

        public static MathOperationRefactored Create(Type type)
        {
            switch (type) 
            { 
                case Type.SuperOperation: return new SuperSummatorRefactored(); 
            }

            return new MathOperationRefactored(type);
        }

        public int DoOperation(int a, int b)
        {
            switch (_type)
            {
                
            }

            return 0;
        }
    }

    public class SuperSummatorRefactored : MathOperationRefactored
    {
        protected SuperSummatorRefactored(Type type) : base(type)
        {
        }

        public SuperSummatorRefactored() : base(Type.SuperOperation)
        {
            
        }
    }
}