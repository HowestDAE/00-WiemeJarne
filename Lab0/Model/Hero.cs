using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0.Model
{
    internal class Hero
    {
		private string _myNemisis;

		public string MyNemisis
		{
			get {
				if(string.IsNullOrWhiteSpace(_myNemisis)) return "(no name)";
				return _myNemisis;
			}
			set {
				if (value != null && value.Length > 10) throw new ArgumentException("naam mag niet langer dan 10 tekens zijn");
				_myNemisis = value;
			}
		}

		public string Name { get; set; }

		public int Level {  get; set; }

		public Hero(string name) : this(name, "no nemisis", 1)
		{}

		public Hero(string name, string myNemisis, int level)
		{
			this.Name = name;
			this.Level = level;
			this.MyNemisis = myNemisis;
		}
	}
}
