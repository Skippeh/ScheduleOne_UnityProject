using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	public class ConversationLocation : MonoBehaviour
	{
		public Transform[] StandPoints;

		[HideInInspector]
		public List<NPC> NPCs;

		private Dictionary<NPC, bool> npcReady;

		public bool NPCsReady => false;

		public void Awake()
		{
		}

		public Transform GetStandPoint(NPC npc)
		{
			return null;
		}

		public void SetNPCReady(NPC npc, bool ready)
		{
		}

		public NPC GetOtherNPC(NPC npc)
		{
			return null;
		}
	}
}
