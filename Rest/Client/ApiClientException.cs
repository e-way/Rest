using System;

namespace Rest.Client
{
    public class ApiClientException : Exception
    {
        public ApiClientException(string message) 
            :base (message)
        {

        }
    }
}
