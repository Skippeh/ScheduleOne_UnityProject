using System;
using System.Collections.Generic;
using ScheduleOne.Materials;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class FootstepSounds : MonoBehaviour
	{
		[Serializable]
		public class FootstepSoundGroup
		{
			[Serializable]
			public class MaterialType
			{
				public EMaterialType type;
			}

			public string name;

			public List<AudioClip> clips;

			public List<MaterialType> appliesTo;

			public float PitchMin;

			public float PitchMax;

			public float Volume;
		}

		public const float COOLDOWN_TIME = 0.15f;

		public List<AudioSourceController> sources;

		public List<FootstepSoundGroup> soundGroups;

		private Dictionary<EMaterialType, FootstepSoundGroup> materialFootstepSounds;

		private float lastStepTime;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Step(EMaterialType materialType, float hardness)
		{
		}

		public AudioSourceController GetFreeSource()
		{
			return null;
		}
	}
}
