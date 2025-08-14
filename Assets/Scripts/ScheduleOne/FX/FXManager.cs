namespace ScheduleOne.FX
{
	public class FXManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.FX.FXManager>
	{
		public global::UnityEngine.AudioClip[] PunchImpactsClips;

		public global::UnityEngine.AudioClip[] SlashImpactClips;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController[] ImpactSources;

		[global::UnityEngine.Header("Particle Prefabs")]
		public global::UnityEngine.GameObject PunchParticlePrefab;

		[global::UnityEngine.Header("Trails")]
		public global::UnityEngine.TrailRenderer BulletTrail;

		protected override void Start()
		{
		}

		public void CreateImpactFX(global::ScheduleOne.Combat.Impact impact, global::ScheduleOne.Combat.IDamageable target)
		{
		}

		public void CreateBulletTrail(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, float speed, float range, global::UnityEngine.LayerMask mask)
		{
		}

		private void PlayImpact(global::UnityEngine.AudioClip clip, global::UnityEngine.Vector3 position, float volume)
		{
		}

		private void PlayParticles(global::UnityEngine.GameObject prefab, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		private global::UnityEngine.AudioClip GetImpactSound(global::ScheduleOne.Combat.Impact impact, global::ScheduleOne.Combat.IDamageable target)
		{
			return null;
		}

		private global::UnityEngine.GameObject GetImpactParticles(global::ScheduleOne.Combat.Impact impact, global::ScheduleOne.Combat.IDamageable target)
		{
			return null;
		}

		private global::ScheduleOne.Audio.AudioSourceController GetSource()
		{
			return null;
		}

		private static global::UnityEngine.AudioClip GetRandomClip(global::UnityEngine.AudioClip[] clips)
		{
			return null;
		}
	}
}
