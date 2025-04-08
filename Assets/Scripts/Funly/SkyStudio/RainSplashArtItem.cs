namespace Funly.SkyStudio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "rainSplashArtItem.asset", menuName = "Sky Studio/Rain/Rain Splash Art Item")]
	public class RainSplashArtItem : global::Funly.SkyStudio.SpriteArtItem
	{
		[global::UnityEngine.Range(0f, 1f)]
		public float intensityMultiplier;

		[global::UnityEngine.Range(0f, 1f)]
		public float scaleMultiplier;
	}
}
