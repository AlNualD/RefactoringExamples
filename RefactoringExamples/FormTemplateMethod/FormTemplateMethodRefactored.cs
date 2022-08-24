using System;

namespace RefactoringExamples.FormTemplateMethod
{
    public abstract class BaseClientRefactored
    {
        public BaseClientRefactored(string url)
        {
            Url = url;
        }

        protected string Url { get; }
        
        public void DoRequest()
        {
            PrepareRequest();
            RequestData();
            SavingResults();
        }

        protected abstract void PrepareRequest();

        protected virtual void SavingResults()
        {
            //some work
        }

        protected abstract string RequestData();

    }

    public class RetryingClientRefactored : BaseClientRefactored
    {
        private readonly int _retryCounterMax;
        
        public RetryingClientRefactored(string url, int retryCounterMax) : base(url)
        {
            _retryCounterMax = retryCounterMax;
        }

        protected override void PrepareRequest()
        {
            //some work
        }

        protected override void SavingResults()
        {
            //some work
        }

        protected override string RequestData()
        {
            int i = 0;
            string answ = null;
            while ( i < _retryCounterMax)
            {
                answ = DoRequestData();
                if(answ != null) break;
                i++;
            }
            return answ;
        }

        private string DoRequestData()
        {
            return "data";
        }
    }

    public class SimpleClientRefactored : BaseClientRefactored
    {
        public SimpleClientRefactored(string url) : base(url)
        {
        }
        
        protected override void PrepareRequest()
        {
            //some work
        }

        protected override string RequestData()
        {
            return "data2";
        }
    }


    public class TestC
    {
        public void TestMethod()
        {
            RetryingClient client = new RetryingClient("url", 5);
            
            client.DoRequest();
        }
    }
}