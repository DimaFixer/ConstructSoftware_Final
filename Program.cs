using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;

namespace ConstructSoftware_Final
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                var client = new NamedPipeClientStream("KeyKeeper");
                client.Connect(500);
                StreamReader reader = new StreamReader(client);
                string MyParams = reader.ReadLine();
                string[] ParsedParams;
                if (MyParams.IndexOf('|') > 0)
                {
                    ParsedParams = MyParams.Split('|');
                    if (ParsedParams[0] == null || MessageBox.Show(string.Format("{0}, Do You want to open SNMP Worker in \"{1}\" version?", ParsedParams[1], ParsedParams[0]), "Program Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Run(new Form1(ParsedParams));
                    }
                }
                else
                {
                    MessageBox.Show(MyParams, "Key Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Run(new Form1());
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Run(new Form1());
            }
        }
    }
}