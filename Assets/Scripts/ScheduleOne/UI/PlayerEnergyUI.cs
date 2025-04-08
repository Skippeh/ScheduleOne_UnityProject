namespace ScheduleOne.UI
{
	public class PlayerEnergyUI : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PlayerEnergyUI>
	{
		public global::UnityEngine.UI.Slider Slider;

		public global::UnityEngine.RectTransform SliderRect;

		public global::UnityEngine.UI.Image FillImage;

		public global::TMPro.TextMeshProUGUI Label;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color SliderColor_Green;

		public global::UnityEngine.Color SliderColor_Red;

		private float displayedValue;

		protected override void Awake()
		{
		}

		private void UpdateDisplayedEnergy()
		{
		}

		public void SetDisplayedEnergy(float energy)
		{
		}

		protected virtual void Update()
		{
		}
	}
}
