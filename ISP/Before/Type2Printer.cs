namespace ISP.Before
{
    public class Type2Printer : IPrintTasks
    {
        public bool printContent(string content)
        {
            return true;
        }

        //not supported, but implemented 
        public bool printDuplexContent(string content)
        {
            return false;
        }

        public bool printPhotocopyContent(string content)
        {
            return true;
        }
    }
}
