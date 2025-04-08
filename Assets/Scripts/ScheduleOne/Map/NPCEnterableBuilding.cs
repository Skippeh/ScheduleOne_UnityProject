namespace ScheduleOne.Map
{
	public class NPCEnterableBuilding : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public const float DOOR_SOUND_DISTANCE_LIMIT = 15f;

		[global::UnityEngine.Header("Settings")]
		public string BuildingName;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Doors.StaticDoor[] Doors;

		[global::UnityEngine.Header("Readonly")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> Occupants;

		public global::System.Guid GUID { get; protected set; }

		public int OccupantCount => 0;

		protected virtual void Awake()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public virtual void NPCEnteredBuilding(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual void NPCExitedBuilding(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		[global::EasyButtons.Button]
		public void GetDoors()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> GetSummonableNPCs()
		{
			return null;
		}

		public global::ScheduleOne.Doors.StaticDoor GetClosestDoor(global::UnityEngine.Vector3 pos, bool useableOnly)
		{
			return null;
		}
	}
}
