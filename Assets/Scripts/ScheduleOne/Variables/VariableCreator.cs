using System;

namespace ScheduleOne.Variables
{
	[Serializable]
	public class VariableCreator
	{
		public string Name;

		public VariableDatabase.EVariableType Type;

		public string InitialValue;

		public bool Persistent;

		public EVariableMode Mode;
	}
}
