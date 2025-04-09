using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	public class AvatarEffects : MonoBehaviour
	{
		[Header("References")]
		public Avatar Avatar;

		public ParticleSystem[] StinkParticles;

		public ParticleSystem VomitParticles;

		public ParticleSystem HeadPoofParticles;

		public ParticleSystem FartParticles;

		public ParticleSystem AntiGravParticles;

		public ParticleSystem FireParticles;

		public OptimizedLight FireLight;

		public ParticleSystem FoggyEffects;

		public Transform HeadBone;

		public Transform NeckBone;

		public AvatarEffects[] MirrorEffectsTo;

		public ParticleSystem ZapParticles;

		public CountdownExplosion CountdownExplosion;

		public GameObject[] ObjectsToCull;

		[Header("Settings")]
		public bool DisableHead;

		[Header("Sounds")]
		public AudioSourceController GurgleSound;

		public AudioSourceController VomitSound;

		public AudioSourceController PoofSound;

		public AudioSourceController FartSound;

		public AudioSourceController FireSound;

		public AudioSourceController ZapSound;

		public AudioSourceController ZapLoopSound;

		[Header("Smoothers")]
		[SerializeField]
		private FloatSmoother AdditionalWeightController;

		[SerializeField]
		private FloatSmoother AdditionalGenderController;

		[SerializeField]
		private FloatSmoother HeadSizeBoost;

		[SerializeField]
		private FloatSmoother NeckSizeBoost;

		[SerializeField]
		private ColorSmoother SkinColorSmoother;

		private bool laxativeEnabled;

		private Color currentEmission;

		private Color targetEmission;

		private bool isCulled;

		private void Start()
		{
		}

		public void FixedUpdate()
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

		public void OverrideHairColor(Color color, bool mirror = true)
		{
		}

		public void ResetHairColor(bool mirror = true)
		{
		}

		public void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
		}

		public void ResetEyeColor(bool mirror = true)
		{
		}

		public void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
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

		public void SetGlowingOn(Color color, bool mirror = true)
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
