using System;
using System.Collections.Generic;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	[Serializable]
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

		[SerializeField]
		protected List<NPC> FullGameConnections;

		[SerializeField]
		protected List<NPC> DemoConnections;

		public Action<float> onRelationshipChange;

		public Action<EUnlockType, bool> onUnlocked;

		public float RelationDelta { get; protected set; }

		public float NormalizedRelationDelta => 0f;

		public bool Unlocked { get; protected set; }

		public EUnlockType UnlockType { get; protected set; }

		public NPC NPC { get; protected set; }

		public List<NPC> Connections => null;

		public void SetNPC(NPC npc)
		{
		}

		public void Init(NPC npc)
		{
		}

		public virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
		}

		public virtual void SetRelationship(float newDelta)
		{
		}

		public virtual void Unlock(EUnlockType type, bool notify = true)
		{
		}

		public virtual void UnlockConnections()
		{
		}

		public RelationshipData GetSaveData()
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

		public List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			return null;
		}

		public List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			return null;
		}

		public List<NPC> GetLockedSuppliers()
		{
			return null;
		}
	}
}
