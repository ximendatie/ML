using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

using System.IO;
using System.Collections;

namespace ML
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHtml = File.ReadAllText(@"F:\weps2007_data_1.1\traininig\web_pages\Elmo_Hardy\raw\000\index.html");

            //Regex regex1 = new Regex("<script((.|\n)+?)/script>", RegexOptions.IgnoreCase);
           // string strOutput = regex1.Replace(strHtml, "");//替换掉JS里面的function及其他

            Regex regex = new Regex("(<script((.|\n)+?)/script>)|(<(.|\n)+?>)", RegexOptions.IgnoreCase);
            string strOutput = regex.Replace(strHtml, "");//替换掉"<"和">"及之间的内容


            strOutput = strOutput.Replace("&nbsp;", "");
            strOutput = strOutput.Replace("\n", " ");
            strOutput = strOutput.Replace("\r", " ");
            Console.WriteLine(strOutput);
            File.WriteAllText(@"C: \Users\qq\Desktop\a.html", strOutput);
        
            Console.ReadLine();

        }
    }
}
