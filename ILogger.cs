using System.Drawing;

namespace AuthenticationService
{
    public interface ILogger
    {
        public void WriteEvent(string eventMassage);

        public void WriteError(string errorMassage);
    }
}
