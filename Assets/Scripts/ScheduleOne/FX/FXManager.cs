using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.FX
{
	public class FXManager : Singleton<FXManager>
	{
		public AudioClip[] PunchImpactsClips;

		public AudioClip[] SlashImpactClips;

		[Header("References")]
		public AudioSourceController[] ImpactSources;

		[Header("Particle Prefabs")]
		public GameObject PunchParticlePrefab;

		[Header("Trails")]
		public TrailRenderer BulletTrail;

		protected override void Start()
		{
		}

		public void CreateImpactFX(Impact impact)
		{
		}

		public void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
		}

		private void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
		}

		private void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
		}

		private AudioClip GetImpactSound(Impact impact)
		{
			return null;
		}

		private GameObject GetImpactParticles(Impact impact)
		{
			return null;
		}

		private AudioSourceController GetSource()
		{
			return null;
		}

		private static AudioClip GetRandomClip(AudioClip[] clips)
		{
			return null;
		}
	}
}
