namespace ScheduleOne.NPCs.Relation
{
	public class NPCUnlockTracker : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.NPCs.NPC Npc;

		public global::UnityEngine.Events.UnityEvent onUnlocked;

		private void Awake()
		{
		}

		private void Invoke(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType type, bool t)
		{
		}
	}
}
