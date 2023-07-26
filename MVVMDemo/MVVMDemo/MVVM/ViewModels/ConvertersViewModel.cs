using System;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
	public class ConvertersViewModel
	{
        public Data Data { get; set; }
		public ConvertersViewModel()
		{
            Data = new Data
            {
                Married = "YES"
            };
        }
	}
}

