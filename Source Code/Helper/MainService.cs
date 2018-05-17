using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex.Helper
{
    public class MainService
    {

        public static void ExecuteLatexCommand(string pathTexFile, string cls = "article", bool hasBib = false)
        {
            try
            {
                string texName = "";

                if (hasBib)
                {
                    texName = Constants.BibTexName;
                }
                else
                {
                    if (cls == "article")
                    {
                        texName = Constants.ArticleTexName;
                    }
                    else if (cls == "report")
                    {
                        texName = Constants.ReportTexName;
                    }
                }

                string xelatexCmd = "xelatex.exe -synctex=1 -interaction=nonstopmode " + texName;
                string bibtexCmd = "bibtex " + texName;
                string hasBibCmd = xelatexCmd + " & " + bibtexCmd + " & " + xelatexCmd + " & " + xelatexCmd;
                string command = hasBib ? "/C " + hasBibCmd : "/C " + xelatexCmd + " & " + xelatexCmd;

                Process p = new Process();
                p.StartInfo.WorkingDirectory = pathTexFile;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments = command;
                p.Start();
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void ChangeControlsEnable(bool isTrue, params Control[] ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                ctrl.Enabled = isTrue;
            }
        }

        public static string ReadLatexFile(string fileName, string fileExt, string pathFile)
        {
            string srcCode = "";
            string path = pathFile + fileName + fileExt;

            using (StreamReader sr = new StreamReader(path))
            {
                srcCode = sr.ReadToEnd();
            }

            return srcCode;
        }

        public static void WriteLatexFile(string fileName, string fileExt, string pathFile, string writeTxt)
        {
            string path = pathFile + fileName + fileExt;

            using (var fileStream = new FileStream(path, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(writeTxt);
            }

        }
    }
}
