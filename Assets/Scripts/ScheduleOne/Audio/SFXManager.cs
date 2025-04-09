using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class SFXManager : Singleton<SFXManager>
	{
		[Serializable]
		public class ImpactType
		{
			public ImpactSoundEntity.EMaterial Material;

			public float MinVolume;

			public float MaxVolume;

			public float MinPitch;

			public float MaxPitch;

			public AudioClip[] Clips;
		}

		public const float MAX_PLAYER_DISTANCE = 40f;

		public const float SQR_MAX_PLAYER_DISTANCE = 1600f;

		public List<ImpactType> ImpactTypes;

		[SerializeField]
		private List<AudioSourceController> soundPool;

		private List<AudioSourceController> soundsInUse;

		public void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
		}

		private void FixedUpdate()
		{
		}

		private AudioSourceController GetSource()
		{
			return null;
		}
	}
}
