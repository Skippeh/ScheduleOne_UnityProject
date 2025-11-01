namespace ScheduleOne.Doors
{
	public class StaticDoor : global::UnityEngine.MonoBehaviour
	{
		public const float KNOCK_COOLDOWN = 2f;

		public const float SUMMON_DURATION = 8f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform AccessPoint;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::ScheduleOne.Audio.AudioSourceController KnockSound;

		public global::ScheduleOne.Map.NPCEnterableBuilding Building;

		[global::UnityEngine.Header("Settings")]
		public bool Usable;

		public bool CanKnock;

		private float timeSinceLastKnock;

		private int doorIndex;

		protected virtual void Awake()
		{
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void Hovered()
		{
		}

		protected virtual bool CanKnockNow()
		{
			return false;
		}

		protected virtual bool IsKnockValid(out string message)
		{
			message = null;
			return false;
		}

		protected virtual void Interacted()
		{
		}

		protected virtual void Knock()
		{
		}

		protected virtual void NPCSelected(global::ScheduleOne.NPCs.NPC npc)
		{
		}
	}
}
