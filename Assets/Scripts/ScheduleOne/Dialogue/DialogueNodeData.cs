using System;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class DialogueNodeData
	{
		public string Guid;

		public string DialogueText;

		public string DialogueNodeLabel;

		public Vector2 Position;

		public DialogueChoiceData[] choices;

		public EVOLineType VoiceLine;

		public DialogueNodeData GetCopy()
		{
			return null;
		}
	}
}
