using System;
using System.Windows.Input;
using PropertyChanged;

namespace MVVMDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class AddTwoNumbersViewModel
    {
        public string Number1
        {
            get;
            set;
        }
        public string Number2
        {
            get;
            set;
        }
        public string Result
        {
            get;
            set;
        }

        public ICommand AddCommand { get; }

        public AddTwoNumbersViewModel()
        {
            AddCommand = new Command(() =>
            {
                Result = Number1 + Number2;
            });
        }
    }
    
}

