using System;

namespace SRP.After
{
    #region Invoice class
    public class Invoice
    {
        #region Variable declaration
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private ILogger _fileLogger;
        private MailSender _emailSender;
        #endregion
        public Invoice(ILogger fileLogger, MailSender emailSender)
        {
            _fileLogger = fileLogger;
            _emailSender = emailSender;
        }
        public void AddInvoice()
        {
            try
            {
                _fileLogger.Trace("Add method Start");
                // Here we need to write the Code for adding new invoice
                // Once the Invoice has been added, then send the  mail
                _emailSender.EMailFrom = "emailfrom@xyz.com";
                _emailSender.EMailTo = "emailto@xyz.com";
                _emailSender.EMailSubject = "Single Responsibility Princile";
                _emailSender.EMailBody = "A class should have only one reason to change";

                _emailSender.SendEmail();
            }
            catch (Exception exception)
            {
                _fileLogger.Error("Error Occurred while Generating Invoice", exception);
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                _fileLogger.Trace("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                _fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
    #endregion
}
