namespace ScheduleOne.Tools
{
	public class ActiveOnMeshVisible : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.MeshRenderer Mesh;

		public global::UnityEngine.GameObject[] ObjectsToActivate;

		public bool Reverse;

		private bool isVisible;

		private void LateUpdate()
		{
		}
	}
}
