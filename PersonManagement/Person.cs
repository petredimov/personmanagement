﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override string ToString()
		{
			return $"Id:{Id} Name: {FirstName} Lastname: {LastName}";
		}
	}
}
