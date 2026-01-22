namespace ScheduleOne.NPCs.Relation
{
	[global::System.Serializable]
	public class NPCRelationData
	{
		public enum EUnlockType
		{
			Recommendation = 0,
			DirectApproach = 1
		}

		public const float MinDelta = 0f;

		public const float MaxDelta = 5f;

		public const float DEFAULT_RELATION_DELTA = 2f;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> FullGameConnections;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> DemoConnections;

		public global::System.Action<float> onRelationshipChange;

		public global::System.Action<global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType, bool> onUnlocked;

		public float RelationDelta { get; protected set; }

		public float NormalizedRelationDelta => 0f;

		public bool Unlocked { get; protected set; }

		public global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType UnlockType { get; protected set; }

		public global::ScheduleOne.NPCs.NPC NPC { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> Connections => null;

		public void SetNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public void Init(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
		}

		public virtual void SetRelationship(float newDelta, bool network = true)
		{
		}

		public virtual void Unlock(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType type, bool notify = true)
		{
		}

		public virtual void UnlockConnections()
		{
		}

		public global::ScheduleOne.Persistence.Datas.RelationshipData GetSaveData()
		{
			return null;
		}

		public float GetAverageMutualRelationship()
		{
			return 0f;
		}

		public bool IsKnown()
		{
			return false;
		}

		public bool IsMutuallyKnown()
		{
			return false;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> GetLockedDealers(bool excludeRecommended)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> GetLockedSuppliers()
		{
			return null;
		}
	}
}
