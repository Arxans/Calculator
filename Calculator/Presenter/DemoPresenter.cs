using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.Presenter
{
    public class DemoPresenter
    {
        private DemoModel model;
        private DemoView view;


        public DemoPresenter(DemoModel model, DemoView view)
        {
            this.model = model;
            this.view = view;

            view.presenter = this;
            view.ResultBtnClickCallback += OnDivClicked;
        }

        public void OnTextChanged(string text)
        {
            model.text = text;
        }
        
        public void OnDivClicked()
        {
            bool bResult = model.Div();

            UpdateView();

            if (!bResult)
                view.ShowSorryView();
        }

        public void ShowError()
        {
            view.ShowSorryView();
        }

        private void UpdateView()
        {
            view.UpdateView(model.text);
        }
    }
}
