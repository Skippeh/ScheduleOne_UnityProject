namespace ScheduleOne.UI
{
	public class NPCSummonMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.NPCSummonMenu>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform EntryContainer;

		public global::UnityEngine.RectTransform[] Entries;

		private global::System.Action<global::ScheduleOne.NPCs.NPC> callback;

		public bool IsOpen { get; private set; }

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public void Open(global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> npcs, global::System.Action<global::ScheduleOne.NPCs.NPC> _callback)
		{
		}

		public void Close()
		{
		}

		public void NPCSelected(global::ScheduleOne.NPCs.NPC npc)
		{
		}
	}
}
