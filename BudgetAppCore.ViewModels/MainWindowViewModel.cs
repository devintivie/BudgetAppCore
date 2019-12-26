using System;

namespace BudgetAppCore.ViewModels
{
    public class MainWindowViewModel
    {
        public BillViewModel BillViewModel { get; set; }

        public MainWindowViewModel()
        {
            BillViewModel = new BillViewModel();
        }
    }

}
