using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	public class MessageBubble : MonoBehaviour
	{
		public enum Alignment
		{
			Center = 0,
			Left = 1,
			Right = 2
		}

		[Header("Settings")]
		public string text;

		public Alignment alignment;

		public bool showTriangle;

		public float bubble_MinWidth;

		public float bubble_MaxWidth;

		public bool alignTextCenter;

		public bool autosetPosition;

		private string displayedText;

		private bool triangleShown;

		[Header("References")]
		public RectTransform container;

		[SerializeField]
		protected Image bubble;

		[SerializeField]
		protected Text content;

		[SerializeField]
		protected Image triangle_Left;

		[SerializeField]
		protected Image triangle_Right;

		public Button button;

		public float height;

		public float spacingAbove;

		public static Color32 backgroundColor_Left;

		public static Color32 textColor_Left;

		public static Color32 backgroundColor_Right;

		public static Color32 textColor_Right;

		public static float baseBubbleSpacing;

		public void SetupBubble(string _text, Alignment _alignment, bool alignCenter = false)
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
