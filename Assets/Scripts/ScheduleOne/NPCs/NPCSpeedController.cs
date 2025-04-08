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

		public float SpeedMultiplier;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.NPCMovement Movement;

		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl> speedControlStack;

		[global::UnityEngine.Header("Debug")]
		public global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl ActiveSpeedControl;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private global::ScheduleOne.NPCs.NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			return null;
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
	}
}
