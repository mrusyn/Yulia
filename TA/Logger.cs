using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TA
{
    public class Logger : LogBase
    {
        private string CurrentDirectory
        {
            get;
            set;
        }

        private string FileName
        {
            get;
            set;
        }

        private string FilePath
        {
            get;
            set;
        }
        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        }

        public override void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
