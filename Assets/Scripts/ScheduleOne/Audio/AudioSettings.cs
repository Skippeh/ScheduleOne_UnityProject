namespace ScheduleOne.Audio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "AudioSettings", menuName = "ScriptableObjects/Audio/Audio Settings")]
	public class AudioSettings : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private string _id;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSettingsWrapper _settings;

		public string Id => null;

		public global::ScheduleOne.Audio.AudioSettingsWrapper Wrapper => null;
	}
}
