using System.Collections.Generic;

namespace ScheduleOne.Police
{
	public class Offense
	{
		public class Charge
		{
			public string chargeName;

			public int crimeIndex;

			public int quantity;

			public Charge(string _chargeName, int _crimeIndex, int _quantity)
			{
			}
		}

		public List<Charge> charges;

		public List<string> penalties;

		public Offense(List<Charge> _charges)
		{
		}
	}
}
