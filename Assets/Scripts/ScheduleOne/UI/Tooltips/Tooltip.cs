namespace ScheduleOne.UI.Tooltips
{
	public class Tooltip : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string text;

		public global::UnityEngine.Vector2 labelOffset;

		private global::UnityEngine.RectTransform rect;

		private global::UnityEngine.Canvas canvas;

		public global::UnityEngine.Vector3 labelPosition => default(global::UnityEngine.Vector3);

		public bool isWorldspace { get; private set; }

		protected virtual void Awake()
		{
		}
	}
}
