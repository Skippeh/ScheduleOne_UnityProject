namespace ScheduleOne.FX
{
	public class PlayerHealthVisuals : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Rendering.Volume[] PPVolumes;

		[global::UnityEngine.Header("Vignette")]
		public float VignetteAlpha_MaxHealth;

		public float VignetteAlpha_MinHealth;

		public global::UnityEngine.AnimationCurve OuterRingCurve;

		[global::UnityEngine.Header("Saturation")]
		public float Saturation_MaxHealth;

		public float Saturation_MinHealth;

		[global::UnityEngine.Header("Chromatic Abberation")]
		public float ChromAb_MaxHealth;

		public float ChromAb_MinHealth;

		[global::UnityEngine.Header("Lens Dirt")]
		public float LensDirt_MaxHealth;

		public float LensDirt_MinHealth;

		private global::Beautify.Universal.Beautify[] _beautifySettings;

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
