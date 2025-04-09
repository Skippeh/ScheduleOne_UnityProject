using UnityEngine;

namespace ScheduleOne.Networking
{
	public class NetworkConditionalObject : MonoBehaviour
	{
		public enum ECondition
		{
			All = 0,
			HostOnly = 1
		}

		public ECondition condition;

		private void Awake()
		{
		}

		public void Check()
		{
		}
	}
}
