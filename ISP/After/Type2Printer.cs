using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.After
{
    public class Type2Printer : IPrintContent, IPrintPhotocopyContent
    {
        public bool printContent(string content)
        {
            return true;
        }

        public bool printPhotocopyContent(string content)
        {
            return true;
        }
    }
}
