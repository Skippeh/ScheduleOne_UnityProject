namespace ScheduleOne.Map
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.BoxCollider))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class Ladder : global::UnityEngine.MonoBehaviour
	{
		public const float NPCClimbOffset = 0.42f;

		public const float LadderMountDismountTimeMultiplier = 0.4f;

		public const float LadderClimbTimeMultiplier = 0.75f;

		public const float NPCClimbSoundInterval = 0.3f;

		public const float PlayerClimbSoundLengthInterval = 0.8f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.AI.OffMeshLink OffMeshLink;

		public global::ScheduleOne.Audio.AudioSourceController ClimbSound;

		public global::ScheduleOne.Doors.SewerDoorController LinkedManholeCover;

		private global::UnityEngine.BoxCollider boxCollider;

		private float timeOnLastClimbSound;

		public global::UnityEngine.Transform LadderTransform => null;

		public global::UnityEngine.Vector2 LadderSize => default(global::UnityEngine.Vector2);

		public global::UnityEngine.Vector3 BottomCenter => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 TopCenter => default(global::UnityEngine.Vector3);

		private void Awake()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public global::UnityEngine.Vector2 ProjectOnLadderSurface(global::UnityEngine.Vector3 position)
		{
			return default(global::UnityEngine.Vector2);
		}

		public global::UnityEngine.Vector2 NormalizeProjectedPosition(global::UnityEngine.Vector2 projectedPosition)
		{
			return default(global::UnityEngine.Vector2);
		}

		public void PlayClimbSound(global::UnityEngine.Vector3 position)
		{
		}
	}
}
