using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	public class DialogueModule : MonoBehaviour
	{
		public EDialogueModule ModuleType;

		public List<Entry> Entries;

		public Entry GetEntry(string key)
		{
			return default(Entry);
		}

		public DialogueChain GetChain(string key)
		{
			return null;
		}

		public bool HasChain(string key)
		{
			return false;
		}

		public string GetLine(string key)
		{
			return null;
		}
	}
}
