using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001
{
    
    class MyForm : Form
    {
        public int i = 0;
        public MyForm(string caption)
        {
            Text = caption;
            Click += new EventHandler(ClickHandler);
            
        }
        public void ClickHandler(Object sender, EventArgs e)
        {
            i++;
            MessageBox.Show($"Стільки раз натиснули на формі - {i.ToString()}.");
        }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            Application.Run(new MyForm("Мій заголовок"));
        }
    }
}
