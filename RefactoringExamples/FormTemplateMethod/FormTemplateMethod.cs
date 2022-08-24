using System;

namespace RefactoringExamples.FormTemplateMethod
{
    public class BaseClient
    {
        protected BaseClient(string url)
        {
            Url = url;
        }

        private string Url { get; }

    }

    public class RetryingClient : BaseClient
    {
        private readonly int _retryCounterMax;
        
        public RetryingClient(string url, int retryCounterMax) : base(url)
        {
            _retryCounterMax = retryCounterMax;
        }

        public void DoRequest()
        {
            PrepareRequest();
            int i = 0;
            string answ;
            while ( i < _retryCounterMax)
            {
                answ = RequestData();
                if(answ != null) break;
                i++;
            }
            SavingResults();
        }

        private void PrepareRequest()
        {
            //some work
        }

        private void SavingResults()
        {
            //some work
        }

        private string RequestData()
        {
            return "data";
        }
    }

    public class SimpleClient : BaseClient
    {
        public SimpleClient(string url) : base(url)
        {
        }
        
        public void DoRequest()
        {
            PrepareRequest();
            RequestData();
            SavingResults();
        }

        private void PrepareRequest()
        {
            //some work
        }

        private void SavingResults()
        {
            //some work
        }

        private string RequestData()
        {
            return "data2";
        }
    }
}