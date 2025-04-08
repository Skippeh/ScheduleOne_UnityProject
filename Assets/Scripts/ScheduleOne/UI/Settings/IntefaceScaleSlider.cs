namespace ScheduleOne.UI.Settings
{
	public class IntefaceScaleSlider : global::ScheduleOne.UI.Settings.SettingsSlider
	{
		public const float MULTIPLIER = 0.1f;

		public const float MinScale = 0.7f;

		public const float MaxScale = 1.4f;

		protected virtual void OnEnable()
		{
		}

		protected override void OnValueChanged(float value)
		{
		}

		protected override string GetDisplayValue(float value)
		{
			return null;
		}
	}
}
