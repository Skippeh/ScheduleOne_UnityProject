using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Lighting;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Calling
{
	public class PayPhone : MonoBehaviour
	{
		public const float RING_INTERVAL = 4f;

		public const float RING_RANGE = 9f;

		public BlinkingLight Light;

		public AudioSourceController RingSound;

		public AudioSourceController AnswerSound;

		public InteractableObject IntObj;

		public Transform CameraPosition;

		private float timeSinceLastRing;

		private const float ringRangeSquared = 81f;

		public PhoneCallData QueuedCall => null;

		public PhoneCallData ActiveCall => null;

		public void FixedUpdate()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanInteract()
		{
			return false;
		}
	}
}
