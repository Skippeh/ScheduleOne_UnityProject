using UnityEngine;

namespace ScheduleOne.Trash
{
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerContents : MonoBehaviour
	{
		public TrashContainer TrashContainer;

		[Header("References")]
		public Transform ContentsTransform;

		public Transform VisualsContainer;

		public Transform VisualsMinTransform;

		public Transform VisualsMaxTransform;

		public Collider Collider;

		protected void Start()
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
