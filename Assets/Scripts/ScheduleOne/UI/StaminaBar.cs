namespace ScheduleOne.UI
{
	public class StaminaBar : global::UnityEngine.MonoBehaviour
	{
		public const float StaminaShowTime = 1.5f;

		public const float StaminaFadeTime = 0.5f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Slider[] Sliders;

		public global::UnityEngine.CanvasGroup Group;

		private global::UnityEngine.Coroutine routine;

		private void Awake()
		{
		}

		private void PlayerSpawned()
		{
		}

		private void UpdateStaminaBar(float change)
		{
		}
	}
}
