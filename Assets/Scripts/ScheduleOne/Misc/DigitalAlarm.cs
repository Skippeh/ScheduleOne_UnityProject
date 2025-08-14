namespace ScheduleOne.Misc
{
	public class DigitalAlarm : global::UnityEngine.MonoBehaviour
	{
		public const float FLASH_FREQUENCY = 4f;

		public global::UnityEngine.MeshRenderer ScreenMesh;

		public int ScreenMeshMaterialIndex;

		public global::TMPro.TextMeshPro ScreenText;

		public bool FlashScreen;

		[global::UnityEngine.Header("Settings")]
		public bool DisplayCurrentTime;

		public global::UnityEngine.Material ScreenOffMat;

		public global::UnityEngine.Material ScreenOnMat;

		private bool isLit;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetScreenLit(bool lit)
		{
		}

		public void DisplayText(string text)
		{
		}

		public void DisplayMinutes(int mins)
		{
		}

		private void MinPass()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
