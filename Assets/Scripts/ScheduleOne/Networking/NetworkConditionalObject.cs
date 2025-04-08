namespace ScheduleOne.Networking
{
	public class NetworkConditionalObject : global::UnityEngine.MonoBehaviour
	{
		public enum ECondition
		{
			All = 0,
			HostOnly = 1
		}

		public global::ScheduleOne.Networking.NetworkConditionalObject.ECondition condition;

		private void Awake()
		{
		}

		public void Check()
		{
		}
	}
}
