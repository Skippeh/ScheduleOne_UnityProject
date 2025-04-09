using TMPro;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	[ExecuteInEditMode]
	public class PlaceholderBuilding : MonoBehaviour
	{
		[Header("Settings")]
		public string Name;

		public Vector3 Dimensions;

		public bool AutoGround;

		[Header("References")]
		public Transform Model;

		public TextMeshPro Label;

		private Vector3 lastFramePosition;

		private void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
