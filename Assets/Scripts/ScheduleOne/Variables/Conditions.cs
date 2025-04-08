namespace ScheduleOne.Variables
{
	[global::System.Serializable]
	public class Conditions
	{
		public enum EEvaluationType
		{
			And = 0,
			Or = 1
		}

		public global::ScheduleOne.Variables.Conditions.EEvaluationType EvaluationType;

		public global::ScheduleOne.Variables.Condition[] ConditionList;

		public global::ScheduleOne.Variables.QuestCondition[] QuestConditionList;

		public bool Evaluate()
		{
			return false;
		}
	}
}
