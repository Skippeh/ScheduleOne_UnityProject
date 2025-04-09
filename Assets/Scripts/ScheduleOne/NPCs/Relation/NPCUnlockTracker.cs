using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Relation
{
	public class NPCUnlockTracker : MonoBehaviour
	{
		public NPC Npc;

		public UnityEvent onUnlocked;

		private void Awake()
		{
		}

		private void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
		}
	}
}
