namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACWindow : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string WindowTitle;

		public global::ScheduleOne.AvatarFramework.Customization.ACWindow Predecessor;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI TitleText;

		public global::UnityEngine.UI.Button BackButton;

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
