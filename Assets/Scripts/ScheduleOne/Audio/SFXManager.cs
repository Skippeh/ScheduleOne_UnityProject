namespace ScheduleOne.Audio
{
	public class SFXManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Audio.SFXManager>
	{
		private static float ImpactSoundMaxRangeSquared;

		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> _soundPool;

		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> _soundsInUse;

		private global::ScheduleOne.Audio.SFXConfiguration _configuration;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void PlayImpactSound(global::ScheduleOne.Core.Audio.EImpactSound material, global::UnityEngine.Vector3 position, float momentum)
		{
		}

		public void PlayFootstepSound(global::ScheduleOne.Core.EMaterialType materialType, float volume, global::UnityEngine.Vector3 position)
		{
		}

		public void SetConfiguration(global::ScheduleOne.Configuration.BaseConfiguration baseConfiguration)
		{
		}

		private void SetupSoundPool()
		{
		}

		private bool TryPullAudioSource(out global::ScheduleOne.Audio.AudioSourceController source)
		{
			source = null;
			return false;
		}
	}
}
