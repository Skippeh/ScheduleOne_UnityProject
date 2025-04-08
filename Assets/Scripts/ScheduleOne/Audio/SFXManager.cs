namespace ScheduleOne.Audio
{
	public class SFXManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Audio.SFXManager>
	{
		[global::System.Serializable]
		public class ImpactType
		{
			public global::ScheduleOne.Audio.ImpactSoundEntity.EMaterial Material;

			public float MinVolume;

			public float MaxVolume;

			public float MinPitch;

			public float MaxPitch;

			public global::UnityEngine.AudioClip[] Clips;
		}

		public const float MAX_PLAYER_DISTANCE = 40f;

		public const float SQR_MAX_PLAYER_DISTANCE = 1600f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.SFXManager.ImpactType> ImpactTypes;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> soundPool;

		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> soundsInUse;

		public void PlayImpactSound(global::ScheduleOne.Audio.ImpactSoundEntity.EMaterial material, global::UnityEngine.Vector3 position, float momentum)
		{
		}

		private void FixedUpdate()
		{
		}

		private global::ScheduleOne.Audio.AudioSourceController GetSource()
		{
			return null;
		}
	}
}
