namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorMenu : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class Window
		{
			public string Name;

			public global::UnityEngine.RectTransform Container;

			public void Open()
			{
			}

			public void Close()
			{
			}
		}

		public global::ScheduleOne.UI.CharacterCreator.CharacterCreatorMenu.Window[] Windows;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI CategoryLabel;

		public global::UnityEngine.UI.Button BackButton;

		public global::UnityEngine.UI.Button NextButton;

		private int openWindowIndex;

		private global::ScheduleOne.UI.CharacterCreator.CharacterCreatorMenu.Window openWindow;

		public void Start()
		{
		}

		public void OpenWindow(int index)
		{
		}

		public void Back()
		{
		}

		public void Next()
		{
		}
	}
}
