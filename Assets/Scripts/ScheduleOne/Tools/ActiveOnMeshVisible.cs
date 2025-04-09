using UnityEngine;

namespace ScheduleOne.Tools
{
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		public MeshRenderer Mesh;

		public GameObject[] ObjectsToActivate;

		public bool Reverse;

		private bool isVisible;

		private void LateUpdate()
		{
		}
	}
}
