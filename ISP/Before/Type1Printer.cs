namespace ISP.Before
{
    public class Type1Printer : IPrintTasks
    {
        public bool printContent(string content)
        {
            return true;
        }

        public bool printDuplexContent(string content)
        {
            return true;
        }

        //not supported, but implemented 
        public bool printPhotocopyContent(string content)
        {
            return false;
        }
    }
}
