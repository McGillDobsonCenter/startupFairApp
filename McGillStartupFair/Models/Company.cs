using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace McGillStartupFair.Models
{
	public class Company{

		public string Name{get; set;}
		public string URL{get; set;}
		public string Description {get; set;} 
        public string ImagePath { get; set; }
		public override string ToString(){ return Name; }

	}
}