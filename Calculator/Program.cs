using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Model;
using Calculator.Presenter;

namespace Calculator
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

            // model
            DemoModel model = new DemoModel();

            // view
            DemoView view = new DemoView();

            // presenter
            DemoPresenter presenter = new DemoPresenter(model, view);

            Application.Run(view);
        }
    }
}
