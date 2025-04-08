namespace ScheduleOne.Misc
{
	public class TreeScaler : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> branchMeshes;

		public float minScale;

		public float maxScale;

		public float minScaleDistance;

		public float maxScaleDistance;

		protected virtual void Start()
		{
		}

		private void UpdateScale()
		{
		}
	}
}
