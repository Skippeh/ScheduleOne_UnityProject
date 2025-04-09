using UnityEngine;

namespace ScheduleOne.UI.Tooltips
{
	public class Tooltip : MonoBehaviour
	{
		[Header("Settings")]
		public string text;

		public Vector2 labelOffset;

		private RectTransform rect;

		private Canvas canvas;

		public Vector3 labelPosition => default(Vector3);

		public bool isWorldspace { get; private set; }

		protected virtual void Awake()
		{
		}
	}
}
