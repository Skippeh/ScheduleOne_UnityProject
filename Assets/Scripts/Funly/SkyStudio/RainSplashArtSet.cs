using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[CreateAssetMenu(fileName = "RainSplashArtSet.asset", menuName = "Sky Studio/Rain/Rain Splash Art Set")]
	public class RainSplashArtSet : SpriteArtSet
	{
		public List<RainSplashArtItem> rainSplashArtItems;
	}
}
