namespace ScheduleOne.Variables
{
	[global::System.Serializable]
	public class VariableCreator
	{
		public string Name;

		public global::ScheduleOne.Variables.VariableDatabase.EVariableType Type;

		public string InitialValue;

		public bool Persistent;

		public global::ScheduleOne.Variables.EVariableMode Mode;
	}
}
