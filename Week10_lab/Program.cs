using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_lab
{
    static class Program
    {
        static List<Form1> forms = new List<Form1>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                forms.Add(new Form1(i));
            }
            Application.Run(forms[0]);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
        public static void NavigateTo(int index)
        {
            for (int i = 0; i < forms.Count; i++)
            {
                if (i == index)
                    forms[i].Show();
                else
                    forms[i].Hide();
            }
        }
    }
}
