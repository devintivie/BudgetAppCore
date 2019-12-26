using BudgetAppCore.Models;
//using Catel.Data;
//using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace BudgetAppCore.ViewModels
{
    public class BillViewModel// : ViewModelBase
    {

        #region Properties
        //[Model]

        //public Bill Bill
        //{
        //    get { return GetValue<Bill>(BillProperty); }
        //    set { SetValue(BillProperty, value); }
        //}

        //public static readonly PropertyData BillProperty = RegisterProperty(nameof(Bill), typeof(Bill), null);
        ////public Bill Bill { get; set; }

        //public DateTime DueDate
        //{
        //    get { return GetValue<DateTime>(DueDateProperty); }
        //    set 
        //    { 
        //        SetValue(DueDateProperty, value);
        //        Console.WriteLine(DueDate);
        //    }
        //}

        //public static readonly PropertyData DueDateProperty = RegisterProperty(nameof(DueDate), typeof(DateTime), DateTime.Now);


        //public bool IsPaid
        //{
        //    get { return GetValue<bool>(IsPaidProperty); }
        //    set 
        //    { 
        //        SetValue(IsPaidProperty, value);
        //        Console.WriteLine(IsPaid);
        //    }
        //}

        //public static readonly PropertyData IsPaidProperty = RegisterProperty(nameof(IsPaid), typeof(bool), true );


        //public double AmountDue
        //{
        //    get { return GetValue<double>(AmountDueProperty); }
        //    set 
        //    { 
        //        SetValue(AmountDueProperty, value);
        //        Console.WriteLine(AmountDue);
        //    }
        //}

        //public static readonly PropertyData AmountDueProperty = RegisterProperty(nameof(AmountDue), typeof(double), 20);



        //public Command TestCommand { get; private set; }

        //// TODO: Move code below to constructor
        
        //// TODO: Move code above to constructor

        //private void OnTestCommandExecute()
        //{
        //    Console.WriteLine("idfk");
        //}




        //public ObservableCollection<string> AccountOptions { get; set; } = new ObservableCollection<string>();
        
        //public DateTime DueDate
        //{
        //    get { return Bill.DueDate; }
        //    set
        //    {
        //        if (Bill.DueDate != value)
        //        {
        //            Bill.DueDate = value;
        //            NotifyPropertyChanged();
        //            NotifyPropertyChanged(nameof(BillStatus));
        //            //Messenger.Send(new VMtoVM());
        //        }
        //    }
        //}

        //public BillStatus BillStatus
        //{
        //    get { return Bill.BillStatus; }
        //    set
        //    {
        //        if (Bill.BillStatus != value)
        //        {
        //            Bill.BillStatus = value;
        //            NotifyPropertyChanged();
        //        }
        //    }
        //}


        //public double AmountDue
        //{
        //    get { return Bill.AmountDue; }
        //    set
        //    {
        //        if (Bill.AmountDue != value)
        //        {
        //            Bill.AmountDue = value;
        //            NotifyPropertyChanged();
        //            //Messenger.Send(new VMtoVM());
        //        }
        //    }
        //}

        //private string selectedAccount;
        //public string SelectedAccount
        //{
        //    get { return selectedAccount; }
        //    set
        //    {
        //        if (selectedAccount != value)
        //        {
        //            selectedAccount = value;
        //            //Bill.AccountID = BankAccountManager.AccountsByNumber[SelectedAccount].UniqueID;
        //            NotifyPropertyChanged();
        //        }
        //    }
        //}

        //private bool isCalendarOpen;
        //public bool IsCalendarOpen
        //{
        //    get { return isCalendarOpen; }
        //    set
        //    {
        //        if (isCalendarOpen != value)
        //        {
        //            isCalendarOpen = value;
        //            NotifyPropertyChanged();
        //        }
        //    }
        //}


        //public bool IsPaid
        //{
        //    get { return Bill.IsPaid; }
        //    set
        //    {
        //        if (Bill.IsPaid != value)
        //        {
        //            Bill.IsPaid = value;
        //            NotifyPropertyChanged();
        //            NotifyPropertyChanged(nameof(BillStatus));
        //            //Messenger.Send(new VMtoVM());
        //        }
        //    }
        //}

        #endregion

        #region Commands
        //public ICommand OpenPopupCommand { get; set; }
        //public Command<object, object> Add { get; private set; }
        #endregion

        #region Constructors
        public BillViewModel(Bill nBill)
        {
            //Bill = nBill;
            //OpenPopupCommand = new DelegateCommand(OnOpenPopup, CanOpenPopup);
            //Add = new Command<object, object>(OnAdd, CanAdd);

            //TestCommand = new Command(OnTestCommandExecute);
            Console.WriteLine("bill view model constructor");

        }

        
        

        public BillViewModel() : this(new Bill()) { }
        #endregion

        #region Methods
        //private void OnOpenPopup()
        //{
        //    if (!IsCalendarOpen)
        //    {
        //        IsCalendarOpen = true;
        //    }
        //    else
        //    {
        //        IsCalendarOpen = false;
        //    }
        //}

        //private bool CanOpenPopup()
        //{
        //    return true;
        //}


        private void OnAdd()
        {
            Console.WriteLine("Execute Add Command");
        }

        private bool CanAdd()
        {
            return true;
        }

        #endregion




    }
}
