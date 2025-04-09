using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		[Header("References")]
		public GameObject Container;

		public TextMeshProUGUI Label;

		public Slider Slider;

		public Image SliderFill;

		private bool progressSetThisFrame;

		private void LateUpdate()
		{
		}

		public void ShowProgress(float progress)
		{
		}

		public void Configure(string label, Color sliderFillColor)
		{
		}
	}
}
