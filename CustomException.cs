using System;

namespace AuthenticationService
{
    public class CustomException: Exception
    {
        public CustomException(string massage): base(massage) { }
    }
}
