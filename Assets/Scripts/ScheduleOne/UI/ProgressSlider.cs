namespace ScheduleOne.UI
{
	public class ProgressSlider : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.ProgressSlider>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::TMPro.TextMeshProUGUI Label;

		public global::UnityEngine.UI.Slider Slider;

		public global::UnityEngine.UI.Image SliderFill;

		private bool progressSetThisFrame;

		private void LateUpdate()
		{
		}

		public void ShowProgress(float progress)
		{
		}

		public void Configure(string label, global::UnityEngine.Color sliderFillColor)
		{
		}
	}
}
