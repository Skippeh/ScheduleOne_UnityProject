using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Doors;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class NPCEnterableBuilding : MonoBehaviour, IGUIDRegisterable
	{
		public const float DOOR_SOUND_DISTANCE_LIMIT = 15f;

		[Header("Settings")]
		public string BuildingName;

		[SerializeField]
		protected string BakedGUID;

		[Header("References")]
		public StaticDoor[] Doors;

		[Header("Readonly")]
		[SerializeField]
		private List<NPC> Occupants;

		public Guid GUID { get; protected set; }

		public int OccupantCount => 0;

		protected virtual void Awake()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public virtual void NPCEnteredBuilding(NPC npc)
		{
		}

		public virtual void NPCExitedBuilding(NPC npc)
		{
		}

		[Button]
		public void GetDoors()
		{
		}

		public List<NPC> GetSummonableNPCs()
		{
			return null;
		}

		public StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			return null;
		}
	}
}
