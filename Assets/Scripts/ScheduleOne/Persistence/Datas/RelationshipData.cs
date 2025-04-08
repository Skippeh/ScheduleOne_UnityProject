namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class RelationshipData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public float RelationDelta;

		public bool Unlocked;

		public global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType UnlockType;

		public RelationshipData(float relationDelta, bool unlocked, global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType unlockType)
		{
		}
	}
}
