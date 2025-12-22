namespace ScheduleOne.UI
{
	public class InteractionCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.InteractionCanvas>
	{
		public const float DISPLAY_SIZE_MULTIPLIER = 0.75f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color DefaultMessageColor;

		public global::UnityEngine.Color DefaultIconColor;

		public global::UnityEngine.Color DefaultKeyColor;

		public global::UnityEngine.Color InvalidMessageColor;

		public global::UnityEngine.Color InvalidIconColor;

		public global::UnityEngine.Sprite KeyIcon;

		public global::UnityEngine.Sprite LeftMouseIcon;

		public global::UnityEngine.Sprite CrossIcon;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.Image Icon;

		public global::UnityEngine.UI.Text IconText;

		public global::UnityEngine.UI.Text MessageText;

		public global::UnityEngine.RectTransform WSLabelContainer;

		public global::UnityEngine.RectTransform BackgroundImage;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject WSLabelPrefab;

		private bool _interactionDisplayEnabledThisFrame;

		private global::UnityEngine.Coroutine _displayScaleLerpRoutine;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Interaction.WorldSpaceLabel> ActiveWSlabels;

		public float displayScale { get; set; }

		protected virtual void LateUpdate()
		{
		}

		public void EnableInteractionDisplay(global::UnityEngine.Vector3 pos, global::UnityEngine.Sprite icon, string spriteText, string message, global::UnityEngine.Color messageColor, global::UnityEngine.Color iconColor)
		{
		}

		public void LerpDisplayScale(float endScale)
		{
		}
	}
}
