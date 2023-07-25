using System;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
	public class PeopleViewModel
	{
		public List<Person> People { get; set; } = new List<Person>();

		public PeopleViewModel()
		{
            People.Add(new Person(){ Name = "Hector", Age = 42, Married = true, BirthDate = new DateTime(2000, 08, 05), Weight = 75, LunchTime = new TimeSpan(10, 0, 0)});
            People.Add(new Person() { Name = "Cristiano", Age = 87, Married = true, BirthDate = new DateTime(2010, 08, 05), Weight = 45, LunchTime = new TimeSpan(4, 0, 4) });
            People.Add(new Person() { Name = "Ronaldo", Age = 23, Married = false, BirthDate = new DateTime(2020, 08, 05), Weight = 65, LunchTime = new TimeSpan(1, 5, 0) });
            People.Add(new Person() { Name = "Ram", Age = 45, Married = true, BirthDate = new DateTime(2000, 08, 05), Weight = 85, LunchTime = new TimeSpan(13, 0, 0) });

        }

	}
}

