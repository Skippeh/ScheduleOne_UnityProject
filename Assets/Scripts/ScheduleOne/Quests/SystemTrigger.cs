namespace ScheduleOne.Quests
{
	[global::System.Serializable]
	public class SystemTrigger
	{
		public global::ScheduleOne.Variables.Conditions Conditions;

		[global::UnityEngine.Header("True")]
		public global::ScheduleOne.Variables.VariableSetter[] onEvaluateTrueVariableSetters;

		public global::ScheduleOne.Quests.QuestStateSetter[] onEvaluateTrueQuestSetters;

		public global::UnityEngine.Events.UnityEvent onEvaluateTrue;

		[global::UnityEngine.Header("False")]
		public global::ScheduleOne.Variables.VariableSetter[] onEvaluateFalseVariableSetters;

		public global::ScheduleOne.Quests.QuestStateSetter[] onEvaluateFalseQuestSetters;

		public global::UnityEngine.Events.UnityEvent onEvaluateFalse;

		public bool Trigger()
		{
			return false;
		}
	}
}
