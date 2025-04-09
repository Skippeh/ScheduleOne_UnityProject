using UnityEngine;

namespace ScheduleOne.Tools
{
	public class ActiveInRange : MonoBehaviour
	{
		public float Distance;

		public bool ScaleByLODBias;

		public GameObject[] ObjectsToActivate;

		public bool Reverse;

		private bool isVisible;

		private void LateUpdate()
		{
		}
	}
}
