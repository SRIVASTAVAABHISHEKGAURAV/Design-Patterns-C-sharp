namespace ISP.Before
{
    public interface IPrintTasks
    {
        bool printContent(string content);
        bool printPhotocopyContent(string content);
        bool printDuplexContent(string content);
    }
}
