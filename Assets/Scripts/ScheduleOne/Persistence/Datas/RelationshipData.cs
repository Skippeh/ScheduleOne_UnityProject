using System;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class RelationshipData : SaveData
	{
		public float RelationDelta;

		public bool Unlocked;

		public NPCRelationData.EUnlockType UnlockType;

		public RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType)
		{
		}
	}
}
