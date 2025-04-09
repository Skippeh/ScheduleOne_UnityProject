using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[CreateAssetMenu(fileName = "LightningArtSet.asset", menuName = "Sky Studio/Lightning/Lightning Art Set")]
	public class LightningArtSet : SpriteArtSet
	{
		[Tooltip("List of lighting bolt art that will be used for customization.")]
		public List<LightningArtItem> lightingStyleItems;
	}
}
