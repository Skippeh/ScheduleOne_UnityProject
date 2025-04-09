using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class StaminaBar : MonoBehaviour
	{
		public const float StaminaShowTime = 1.5f;

		public const float StaminaFadeTime = 0.5f;

		[Header("References")]
		public Slider[] Sliders;

		public CanvasGroup Group;

		private Coroutine routine;

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
