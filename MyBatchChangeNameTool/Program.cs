using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBatchChangeNameTool
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchChangeNameTool tool = new BatchChangeNameTool();
            string input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                input = "s{0:D4}";
            }
            tool.ChangeName(input);
        }
    }
}
