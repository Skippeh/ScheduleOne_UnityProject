namespace Funly.SkyStudio
{
	public class SkyProfileOverride : global::UnityEngine.MonoBehaviour
	{
		public global::Funly.SkyStudio.SkyProfile SkyProfile;

		[global::UnityEngine.Range(0f, 1f)]
		public float Strength;

		[global::UnityEngine.Header("Masks")]
		public bool AffectAmbientLight;

		public bool AffectFog;

		public bool AffectSunLight;

		public void Apply(global::Funly.SkyStudio.SkyProfileOutput output, float timeOfDay)
		{
		}
	}
}
