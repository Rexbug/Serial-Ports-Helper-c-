using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApplication2._03_Function
{
    class Function
    {
        internal static OpenFileDialog openFile()
        {
            var ofd = new OpenFileDialog();
            /*   if (ofd.ShowDialog() == DialogResult.OK)
               {
                   File.Copy(ofd.FileName, AppDomain.CurrentDomain.BaseDirectory + "\\a.txt");// 复制到exe目录下

               }*/
            return ofd;
        }


    }
}
