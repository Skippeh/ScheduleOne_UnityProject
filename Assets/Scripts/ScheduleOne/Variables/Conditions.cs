using System;

namespace ScheduleOne.Variables
{
	[Serializable]
	public class Conditions
	{
		public enum EEvaluationType
		{
			And = 0,
			Or = 1
		}

		public EEvaluationType EvaluationType;

		public Condition[] ConditionList;

		public QuestCondition[] QuestConditionList;

		public bool Evaluate()
		{
			return false;
		}
	}
}
