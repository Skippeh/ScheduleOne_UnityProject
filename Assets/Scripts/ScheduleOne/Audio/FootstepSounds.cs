namespace ScheduleOne.Audio
{
	public class FootstepSounds : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class FootstepSoundGroup
		{
			[global::System.Serializable]
			public class MaterialType
			{
				public global::ScheduleOne.Materials.EMaterialType type;
			}

			public string name;

			public global::System.Collections.Generic.List<global::UnityEngine.AudioClip> clips;

			public global::System.Collections.Generic.List<global::ScheduleOne.Audio.FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo;

			public float PitchMin;

			public float PitchMax;

			public float Volume;
		}

		public const float COOLDOWN_TIME = 0.15f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> sources;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.FootstepSounds.FootstepSoundGroup> soundGroups;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Materials.EMaterialType, global::ScheduleOne.Audio.FootstepSounds.FootstepSoundGroup> materialFootstepSounds;

		private float lastStepTime;

		public float VolumeMultiplier { get; set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Step(global::ScheduleOne.Materials.EMaterialType materialType, float hardness)
		{
		}

		public global::ScheduleOne.Audio.AudioSourceController GetFreeSource()
		{
			return null;
		}
	}
}
