using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		public Canvas Canvas;

		public Button PhoneButton;

		public Button CharacterButton;

		public RectTransform SelectionIndicator;

		public CharacterInterface CharacterInterface;

		private Coroutine selectionLerp;

		protected override void Awake()
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

		public void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
		}
	}
}
