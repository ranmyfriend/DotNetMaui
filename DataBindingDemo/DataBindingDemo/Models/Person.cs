using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DataBindingDemo.Models
{
	public class Person: INotifyPropertyChanged
	{
		private string name;

		public string Name
		{
			get => name;
			set
			{
				name = value;
				OnPropertyChanged(); //this helps to update the UserInterface!
				//when ever we set the new value to the property, automatically the ui get updated.
			} 
		}

		private string phone;
		public string Phone {
            get => phone;
            set
            {
                phone = value;
                OnPropertyChanged();
            }
        }
		private string address;
		public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
    }
}

