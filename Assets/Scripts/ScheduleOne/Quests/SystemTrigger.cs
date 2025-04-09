using System;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	[Serializable]
	public class SystemTrigger
	{
		public Conditions Conditions;

		[Header("True")]
		public VariableSetter[] onEvaluateTrueVariableSetters;

		public QuestStateSetter[] onEvaluateTrueQuestSetters;

		public UnityEvent onEvaluateTrue;

		[Header("False")]
		public VariableSetter[] onEvaluateFalseVariableSetters;

		public QuestStateSetter[] onEvaluateFalseQuestSetters;

		public UnityEvent onEvaluateFalse;

		public bool Trigger()
		{
			return false;
		}
	}
}
