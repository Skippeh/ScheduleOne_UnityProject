namespace ScheduleOne.UI.Settings
{
	public class AudioSlider : global::ScheduleOne.UI.Settings.SettingsSlider
	{
		public const float MULTIPLIER = 0.01f;

		public bool Master;

		public global::ScheduleOne.Audio.EAudioType AudioType;

		protected virtual void Start()
		{
		}

		protected override void OnValueChanged(float value)
		{
		}
	}
}
