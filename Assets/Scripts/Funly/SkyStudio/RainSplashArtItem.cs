using UnityEngine;

namespace Funly.SkyStudio
{
	[CreateAssetMenu(fileName = "rainSplashArtItem.asset", menuName = "Sky Studio/Rain/Rain Splash Art Item")]
	public class RainSplashArtItem : SpriteArtItem
	{
		[Range(0f, 1f)]
		public float intensityMultiplier;

		[Range(0f, 1f)]
		public float scaleMultiplier;
	}
}
