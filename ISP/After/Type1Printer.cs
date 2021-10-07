using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.After
{
    public class Type1Printer : IPrintContent, IPrintDuplexContent
    {
        public bool printContent(string content)
        {
            return true;
        }

        public bool printDuplexContent(string content)
        {
            return true;
        }

    }
}
