namespace ScheduleOne.VoiceOver
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class VOEmitter : global::UnityEngine.MonoBehaviour
	{
		public const float PitchVariation = 0.05f;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.VoiceOver.VODatabase Database;

		[global::UnityEngine.Range(0.5f, 2f)]
		public float PitchMultiplier;

		private float runtimePitchMultiplier;

		protected global::ScheduleOne.Audio.AudioSourceController audioSourceController;

		private global::ScheduleOne.VoiceOver.VODatabase defaultVODatabase;

		protected virtual void Awake()
		{
		}

		public virtual void Play(global::ScheduleOne.VoiceOver.EVOLineType lineType)
		{
		}

		public void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
		}

		public void SetDatabase(global::ScheduleOne.VoiceOver.VODatabase database, bool writeDefault = true)
		{
		}

		public void ResetDatabase()
		{
		}
	}
}
