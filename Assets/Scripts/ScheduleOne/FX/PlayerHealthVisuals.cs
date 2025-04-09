using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.FX
{
	public class PlayerHealthVisuals : MonoBehaviour
	{
		[Header("References")]
		public Volume GlobalVolume;

		[Header("Vignette")]
		public float VignetteAlpha_MaxHealth;

		public float VignetteAlpha_MinHealth;

		public AnimationCurve OuterRingCurve;

		[Header("Saturation")]
		public float Saturation_MaxHealth;

		public float Saturation_MinHealth;

		[Header("Chromatic Abberation")]
		public float ChromAb_MaxHealth;

		public float ChromAb_MinHealth;

		[Header("Lens Dirt")]
		public float LensDirt_MaxHealth;

		public float LensDirt_MinHealth;

		private Beautify.Universal.Beautify _beautifySettings;

		private void Awake()
		{
		}

		private void Spawned()
		{
		}

		private void MinPass()
		{
		}

		private void UpdateEffects(float newHealth)
		{
		}
	}
}
