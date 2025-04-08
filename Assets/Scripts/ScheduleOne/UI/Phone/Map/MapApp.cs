namespace ScheduleOne.UI.Phone.Map
{
	public class MapApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Map.MapApp>
	{
		public const float KeyMoveSpeed = 1.25f;

		public global::UnityEngine.RectTransform ContentRect;

		public global::UnityEngine.RectTransform PoIContainer;

		public global::UnityEngine.UI.Scrollbar HorizontalScrollbar;

		public global::UnityEngine.UI.Scrollbar VerticalScrollbar;

		public global::UnityEngine.UI.Image BackgroundImage;

		public global::UnityEngine.CanvasGroup LabelGroup;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Sprite DemoMapSprite;

		public global::UnityEngine.Sprite MainMapSprite;

		public global::UnityEngine.Sprite TutorialMapSprite;

		public float LabelScrollMin;

		public float LabelScrollMax;

		[global::UnityEngine.HideInInspector]
		public bool SkipFocusPlayer;

		private global::UnityEngine.Coroutine contentMoveRoutine;

		private bool opened;

		protected override void Start()
		{
		}

		public override void SetOpen(bool open)
		{
		}

		protected override void Update()
		{
		}

		public void FocusPosition(global::UnityEngine.Vector2 anchoredPosition)
		{
		}
	}
}
