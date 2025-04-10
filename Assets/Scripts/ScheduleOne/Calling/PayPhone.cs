namespace ScheduleOne.Calling
{
	public class PayPhone : global::UnityEngine.MonoBehaviour
	{
		public const float RING_INTERVAL = 4f;

		public const float RING_RANGE = 9f;

		public global::ScheduleOne.Lighting.BlinkingLight Light;

		public global::ScheduleOne.Audio.AudioSourceController RingSound;

		public global::ScheduleOne.Audio.AudioSourceController AnswerSound;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition;

		private float timeSinceLastRing;

		private const float ringRangeSquared = 81f;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData QueuedCall => null;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData ActiveCall => null;

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
