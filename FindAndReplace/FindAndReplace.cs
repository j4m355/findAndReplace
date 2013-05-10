using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;


namespace FindAndReplace
{
    public class FindAndReplace
    {
        public bool ProcessDirectory(string directoryPath, string findString, string replaceString)
        {
            if (!Directory.Exists(directoryPath)) return false;

            var outputDir = directoryPath + @"output\";

            if (!Directory.Exists(outputDir)) Directory.CreateDirectory(outputDir);


            foreach (var file in Directory.GetFiles(directoryPath))
            {
                var streamReader = new StreamReader(file);
                var text = streamReader.ReadToEnd();
                text = text.Replace(findString, replaceString);
                streamReader.Close();
                var streamWriter = new StreamWriter(outputDir + Path.GetFileName(file));
                streamWriter.Write(text);
                streamWriter.Close();
            }
            
            Process.Start(outputDir);

            return true;

        }

      
    }
}
