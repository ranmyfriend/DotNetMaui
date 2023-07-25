using System;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
	public class PersonViewModel
	{
        public Person Person { get; set; }
		public PersonViewModel()
		{
             Person = new Person
            {
                Name = "Hector",
                Age = 50,
                Married = true,
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 100,
                LunchTime = new TimeSpan(10, 0, 0)
            };
        }
	}
}

