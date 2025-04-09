using ScheduleOne.Audio;

namespace ScheduleOne.UI.Settings
{
	public class AudioSlider : SettingsSlider
	{
		public const float MULTIPLIER = 0.01f;

		public bool Master;

		public EAudioType AudioType;

		protected virtual void Start()
		{
		}

		protected override void OnValueChanged(float value)
		{
		}
	}
}
