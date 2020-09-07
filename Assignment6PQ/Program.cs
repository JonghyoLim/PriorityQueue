using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//public struct Patient
//{
//    public String name;
//    public int priority;
//    public Patient(String name, int priority)
//    {
//        this.name = name;
//        this.priority = priority;
//    }
//}

namespace Assignment6PQ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
