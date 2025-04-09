using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Map
{
	public class MapApp : App<MapApp>
	{
		public const float KeyMoveSpeed = 1.25f;

		public RectTransform ContentRect;

		public RectTransform PoIContainer;

		public Scrollbar HorizontalScrollbar;

		public Scrollbar VerticalScrollbar;

		public Image BackgroundImage;

		public CanvasGroup LabelGroup;

		[Header("Settings")]
		public Sprite DemoMapSprite;

		public Sprite MainMapSprite;

		public Sprite TutorialMapSprite;

		public float LabelScrollMin;

		public float LabelScrollMax;

		[HideInInspector]
		public bool SkipFocusPlayer;

		private Coroutine contentMoveRoutine;

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

		public void FocusPosition(Vector2 anchoredPosition)
		{
		}
	}
}
