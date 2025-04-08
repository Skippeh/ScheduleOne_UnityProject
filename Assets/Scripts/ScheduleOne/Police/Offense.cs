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

		public global::System.Collections.Generic.List<global::ScheduleOne.Police.Offense.Charge> charges;

		public global::System.Collections.Generic.List<string> penalties;

		public Offense(global::System.Collections.Generic.List<global::ScheduleOne.Police.Offense.Charge> _charges)
		{
		}
	}
}
