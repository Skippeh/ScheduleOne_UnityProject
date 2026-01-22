namespace ScheduleOne.NPCs.Other
{
	public class SprayPaint : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.NPCs.NPC _npc;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable _sprayPaintPrefab;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.AvatarFramework.Animation.AvatarAnimation _anim;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _spraySound;

		private global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable _sprayPaint;

		private global::UnityEngine.ParticleSystem _sprayEffect;

		private void Awake()
		{
		}

		public void Begin()
		{
		}

		public void End()
		{
		}

		public void SetEffect(bool value, global::UnityEngine.Color colour = default(global::UnityEngine.Color))
		{
		}
	}
}
