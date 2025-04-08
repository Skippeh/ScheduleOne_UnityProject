namespace ScheduleOne.ScriptableObjects
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "PhoneCallData", menuName = "ScriptableObjects/PhoneCallData", order = 1)]
	public class PhoneCallData : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class Stage
		{
			[global::UnityEngine.TextArea(3, 10)]
			public string Text;

			public global::ScheduleOne.Quests.SystemTrigger[] OnStartTriggers;

			public global::ScheduleOne.Quests.SystemTrigger[] OnDoneTriggers;

			public void OnStageStart()
			{
			}

			public void OnStageEnd()
			{
			}
		}

		public global::ScheduleOne.ScriptableObjects.CallerID CallerID;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData.Stage[] Stages;

		public global::UnityEngine.Events.UnityEvent onCallCompleted;

		public void Completed()
		{
		}
	}
}
