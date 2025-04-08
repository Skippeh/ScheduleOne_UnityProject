namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.ExecuteInEditMode]
	public class PlaceholderBuilding : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string Name;

		public global::UnityEngine.Vector3 Dimensions;

		public bool AutoGround;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Model;

		public global::TMPro.TextMeshPro Label;

		private global::UnityEngine.Vector3 lastFramePosition;

		private void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
