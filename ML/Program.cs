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
            string strHtml = File.ReadAllText(@"C:\Users\qq\Documents\Tencent Files\602710492\FileRecv\index.html");

            //Regex regex1 = new Regex("<script((.|\n)+?)/script>", RegexOptions.IgnoreCase);
           // string strOutput = regex1.Replace(strHtml, "");//替换掉JS里面的function及其他

            Regex regex = new Regex("(<script((.|\n)+?)/script>)|(<(.|\n)+?>)", RegexOptions.IgnoreCase);
            string strOutput = regex.Replace(strHtml, "");//替换掉"<"和">"及之间的内容

           // Regex regex2 = new Regex("{(.|\n)+?}", RegexOptions.IgnoreCase);
           // strOutput = regex2.Replace(strHtml, "");//替换掉"<"和">"及之间的内容

            strOutput = strOutput.Replace("&nbsp;", "");
            Console.WriteLine(strOutput);
            File.WriteAllText(@"C: \Users\qq\Desktop\a.html", strOutput);
        
            Console.ReadLine();

        }
    }
}
