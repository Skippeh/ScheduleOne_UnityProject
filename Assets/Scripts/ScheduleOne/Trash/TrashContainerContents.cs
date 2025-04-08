namespace ScheduleOne.Trash
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Trash.TrashContainer))]
	public class TrashContainerContents : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Trash.TrashContainer TrashContainer;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ContentsTransform;

		public global::UnityEngine.Transform VisualsContainer;

		public global::UnityEngine.Transform VisualsMinTransform;

		public global::UnityEngine.Transform VisualsMaxTransform;

		public global::UnityEngine.Collider Collider;

		protected void Start()
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
