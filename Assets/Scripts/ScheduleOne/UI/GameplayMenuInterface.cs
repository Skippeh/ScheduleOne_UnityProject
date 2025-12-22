namespace ScheduleOne.UI
{
	public class GameplayMenuInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.GameplayMenuInterface>
	{
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.UI.Button PhoneButton;

		public global::UnityEngine.UI.Button CharacterButton;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::ScheduleOne.UI.CharacterInterface CharacterInterface;

		private global::UnityEngine.Coroutine selectionLerp;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void PhoneClicked()
		{
		}

		public void CharacterClicked()
		{
		}

		public void SetSelected(global::ScheduleOne.UI.GameplayMenu.EGameplayScreen screen)
		{
		}
	}
}
