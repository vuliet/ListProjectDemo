namespace ExceptionTest
{
    public class AppException : Exception
    {
        public AppException(string message) :
            base(message)
        {
        }
    }
}
