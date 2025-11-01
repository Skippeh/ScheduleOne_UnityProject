namespace ScheduleOne.NPCs
{
	public class NPCSpeedController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class SpeedControl
		{
			public string id;

			public int priority;

			public float speed;

			public SpeedControl(string id, int priority, float speed)
			{
			}
		}

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float DefaultWalkSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("SpeedMultiplier")]
		private float _SpeedMultiplier;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.NPCMovement Movement;

		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl> speedControlStack;

		public global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl ActiveSpeedControl;

		public float SpeedMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void AddSpeedControl(global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl control)
		{
		}

		public global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			return null;
		}

		public bool DoesSpeedControlExist(string id)
		{
			return false;
		}

		public void RemoveSpeedControl(string id)
		{
		}

		private void UpdateActiveSpeedControl()
		{
		}
	}
}
