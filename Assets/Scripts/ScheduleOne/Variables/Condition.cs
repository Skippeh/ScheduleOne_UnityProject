using System;

namespace ScheduleOne.Variables
{
	[Serializable]
	public class Condition
	{
		public enum EConditionType
		{
			GreaterThan = 0,
			LessThan = 1,
			EqualTo = 2,
			NotEqualTo = 3,
			GreaterThanOrEqualTo = 4,
			LessThanOrEqualTo = 5
		}

		public string VariableName;

		public EConditionType Operator;

		public string Value;

		public bool Evaluate()
		{
			return false;
		}
	}
}
