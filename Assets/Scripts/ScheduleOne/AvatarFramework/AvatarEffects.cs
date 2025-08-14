namespace ScheduleOne.AvatarFramework
{
	public class AvatarEffects : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::UnityEngine.ParticleSystem[] StinkParticles;

		public global::UnityEngine.ParticleSystem VomitParticles;

		public global::UnityEngine.ParticleSystem HeadPoofParticles;

		public global::UnityEngine.ParticleSystem FartParticles;

		public global::UnityEngine.ParticleSystem AntiGravParticles;

		public global::UnityEngine.ParticleSystem FireParticles;

		public global::ScheduleOne.DevUtilities.OptimizedLight FireLight;

		public global::UnityEngine.ParticleSystem FoggyEffects;

		public global::UnityEngine.Transform HeadBone;

		public global::UnityEngine.Transform NeckBone;

		public global::ScheduleOne.AvatarFramework.AvatarEffects[] MirrorEffectsTo;

		public global::UnityEngine.ParticleSystem ZapParticles;

		public global::ScheduleOne.FX.CountdownExplosion CountdownExplosion;

		public global::UnityEngine.GameObject[] ObjectsToCull;

		[global::UnityEngine.Header("Settings")]
		public bool DisableHead;

		[global::UnityEngine.Header("Sounds")]
		public global::ScheduleOne.Audio.AudioSourceController GurgleSound;

		public global::ScheduleOne.Audio.AudioSourceController VomitSound;

		public global::ScheduleOne.Audio.AudioSourceController PoofSound;

		public global::ScheduleOne.Audio.AudioSourceController FartSound;

		public global::ScheduleOne.Audio.AudioSourceController FireSound;

		public global::ScheduleOne.Audio.AudioSourceController ZapSound;

		public global::ScheduleOne.Audio.AudioSourceController ZapLoopSound;

		[global::UnityEngine.Header("Smoothers")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.FloatSmoother AdditionalWeightController;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.FloatSmoother AdditionalGenderController;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.FloatSmoother HeadSizeBoost;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.FloatSmoother NeckSizeBoost;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.ColorSmoother SkinColorSmoother;

		private bool laxativeEnabled;

		private global::UnityEngine.Color currentEmission;

		private global::UnityEngine.Color targetEmission;

		private bool isCulled;

		private void Start()
		{
		}

		public void Update()
		{
		}

		private void SetEffectsCulled(bool culled)
		{
		}

		public void SetStinkParticlesActive(bool active, bool mirror = true)
		{
		}

		public void TriggerSick(bool mirror = true)
		{
		}

		public void SetAntiGrav(bool active, bool mirror = true)
		{
		}

		public void SetFoggy(bool active, bool mirror = true)
		{
		}

		public void VanishHair(bool mirror = true)
		{
		}

		public void SetZapped(bool zapped, bool mirror = true)
		{
		}

		public void ReturnHair(bool mirror = true)
		{
		}

		public void OverrideHairColor(global::UnityEngine.Color color, bool mirror = true)
		{
		}

		public void ResetHairColor(bool mirror = true)
		{
		}

		public void OverrideEyeColor(global::UnityEngine.Color color, float emission = 0.115f, bool mirror = true)
		{
		}

		public void ResetEyeColor(bool mirror = true)
		{
		}

		public void SetEyeLightEmission(float intensity, global::UnityEngine.Color color, bool mirror = true)
		{
		}

		public void EnableLaxative(bool mirror = true)
		{
		}

		public void DisableLaxative(bool mirror = true)
		{
		}

		public void SetFireActive(bool active, bool mirror = true)
		{
		}

		public void SetBigHeadActive(bool active, bool mirror = true)
		{
		}

		public void SetGiraffeActive(bool active, bool mirror = true)
		{
		}

		public void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
		}

		public void SetSicklySkinColor(bool mirror = true)
		{
		}

		private void SetDefaultSkinColor(bool mirror = true)
		{
		}

		public void SetGenderInverted(bool inverted, bool mirror = true)
		{
		}

		public void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
		}

		public void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
		}

		public void SetGlowingOn(global::UnityEngine.Color color, bool mirror = true)
		{
		}

		public void SetGlowingOff(bool mirror = true)
		{
		}

		public void TriggerCountdownExplosion(bool mirror = true)
		{
		}

		public void StopCountdownExplosion(bool mirror = true)
		{
		}

		public void SetCyclopean(bool enabled, bool mirror = true)
		{
		}

		public void SetZombified(bool zombified, bool mirror = true)
		{
		}
	}
}
