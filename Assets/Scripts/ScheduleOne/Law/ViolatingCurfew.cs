namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class ViolatingCurfew : global::ScheduleOne.Law.Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
