using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBatchChangeNameTool
{
    public class BatchChangeNameTool
    {
        public const string _inputPath = "input";
        public const string _outputPath = "output";

        public static readonly string inputPath, outputPath;
        
        static BatchChangeNameTool()
        {
            inputPath =Path.Combine(Directory.GetCurrentDirectory() , _inputPath);
            outputPath = Path.Combine(Directory.GetCurrentDirectory() , _outputPath);
        }

        public void ChangeName(string format)
        {
            Directory.CreateDirectory(inputPath);
            Directory.CreateDirectory(outputPath);

            var filesPath =  Directory.GetFiles(inputPath);

            int index = 0;
            foreach (var item in filesPath)
            {
                if(index==0)
                {
                    format +=  Path.GetExtension(item);
                }

                string outPath = Path.Combine(outputPath, string.Format(format, index));
                File.Copy(item, outPath, true);
                index++;
            }

        }

    }
}
