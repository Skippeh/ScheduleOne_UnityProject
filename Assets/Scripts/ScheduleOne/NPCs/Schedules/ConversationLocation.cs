namespace ScheduleOne.NPCs.Schedules
{
	public class ConversationLocation : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform[] StandPoints;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> NPCs;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.NPCs.NPC, bool> npcReady;

		public bool NPCsReady => false;

		public void Awake()
		{
		}

		public global::UnityEngine.Transform GetStandPoint(global::ScheduleOne.NPCs.NPC npc)
		{
			return null;
		}

		public void SetNPCReady(global::ScheduleOne.NPCs.NPC npc, bool ready)
		{
		}

		public global::ScheduleOne.NPCs.NPC GetOtherNPC(global::ScheduleOne.NPCs.NPC npc)
		{
			return null;
		}
	}
}
