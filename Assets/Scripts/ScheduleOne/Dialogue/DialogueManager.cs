using System.Collections.Generic;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Dialogue
{
	public class DialogueManager : Singleton<DialogueManager>
	{
		public DialogueDatabase DefaultDatabase;

		public List<DialogueModule> DefaultModules;

		public DialogueModule Get(EDialogueModule moduleType)
		{
			return null;
		}
	}
}
