using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	[CreateAssetMenu(fileName = "New Dialogue Database", menuName = "Dialogue/Dialogue Database")]
	public class DialogueDatabase : ScriptableObject
	{
		public List<DialogueModule> Modules;

		public List<Entry> GenericEntries;

		private DialogueHandler handler;

		private List<DialogueModule> runtimeModules => null;

		public void Initialize(DialogueHandler _handler)
		{
		}

		public DialogueModule GetModule(EDialogueModule moduleType)
		{
			return null;
		}

		public DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			return null;
		}

		public bool HasChain(EDialogueModule moduleType, string key)
		{
			return false;
		}

		public string GetLine(EDialogueModule moduleType, string key)
		{
			return null;
		}
	}
}
