using System;

namespace SRP.After
{
    #region Logger class
    public interface ILogger
    {
        void Trace(string info);
        void Error(string message, Exception ex);
    }
    public class Logger : ILogger
    {
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Trace(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for logging Error information.
        }
    }
    #endregion
}
