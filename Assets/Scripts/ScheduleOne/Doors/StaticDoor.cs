using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Doors
{
	public class StaticDoor : MonoBehaviour
	{
		public const float KNOCK_COOLDOWN = 2f;

		public const float SUMMON_DURATION = 8f;

		[Header("References")]
		public Transform AccessPoint;

		public InteractableObject IntObj;

		public AudioSourceController KnockSound;

		public NPCEnterableBuilding Building;

		[Header("Settings")]
		public bool Usable;

		public bool CanKnock;

		private float timeSinceLastKnock;

		protected virtual void Awake()
		{
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void Update()
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

		protected virtual void NPCSelected(NPC npc)
		{
		}
	}
}
