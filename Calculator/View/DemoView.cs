using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Presenter;

namespace Calculator
{
    public partial class DemoView : Form
    {
        public DemoPresenter presenter { get; set; }
        
        public event Action ResultBtnClickCallback;
        private Point MouseHook;

        public DemoView()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                presenter.OnTextChanged(textBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                ResultBtnClickCallback.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        public void UpdateView(string text)
        {
            textBox.Text = text;
        }

        public void ShowSorryView()
        {
            SorryView sorryView = new SorryView();

            DialogResult result = sorryView.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                textBox.Text = string.Empty;
                presenter.OnTextChanged(string.Empty);
            }
            else
            {
                Application.Exit();
            }
        }

        private void DemoView_Load(object sender, EventArgs e)
        {
            textBox.Text = Properties.Settings.Default.FieldText;
        }

        private void DemoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.FieldText = textBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
