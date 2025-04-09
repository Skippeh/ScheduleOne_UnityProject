using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACWindow : MonoBehaviour
	{
		[Header("Settings")]
		public string WindowTitle;

		public ACWindow Predecessor;

		[Header("References")]
		public TextMeshProUGUI TitleText;

		public Button BackButton;

		private void Start()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
