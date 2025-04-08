namespace ScheduleOne.UI.Phone.Messages
{
	public class MessageBubble : global::UnityEngine.MonoBehaviour
	{
		public enum Alignment
		{
			Center = 0,
			Left = 1,
			Right = 2
		}

		[global::UnityEngine.Header("Settings")]
		public string text;

		public global::ScheduleOne.UI.Phone.Messages.MessageBubble.Alignment alignment;

		public bool showTriangle;

		public float bubble_MinWidth;

		public float bubble_MaxWidth;

		public bool alignTextCenter;

		public bool autosetPosition;

		private string displayedText;

		private bool triangleShown;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform container;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image bubble;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text content;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image triangle_Left;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image triangle_Right;

		public global::UnityEngine.UI.Button button;

		public float height;

		public float spacingAbove;

		public static global::UnityEngine.Color32 backgroundColor_Left;

		public static global::UnityEngine.Color32 textColor_Left;

		public static global::UnityEngine.Color32 backgroundColor_Right;

		public static global::UnityEngine.Color32 textColor_Right;

		public static float baseBubbleSpacing;

		public void SetupBubble(string _text, global::ScheduleOne.UI.Phone.Messages.MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void RefreshDisplayedText()
		{
		}

		protected virtual void RefreshTriangle()
		{
		}
	}
}
