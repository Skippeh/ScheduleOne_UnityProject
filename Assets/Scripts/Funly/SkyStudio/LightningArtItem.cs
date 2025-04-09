using UnityEngine;

namespace Funly.SkyStudio
{
	[CreateAssetMenu(fileName = "lightningArtItem.asset", menuName = "Sky Studio/Lightning/Lightning Art Item")]
	public class LightningArtItem : SpriteArtItem
	{
		public enum Alignment
		{
			ScaleToFit = 0,
			TopAlign = 1
		}

		[Tooltip("Adjust how the lightning bolt is positioned inside the spawn area container.")]
		public Alignment alignment;

		[Tooltip("Thunder sound clip to play when this lighting bolt is rendered.")]
		public AudioClip thunderSound;

		[Tooltip("Probability adjustment for this specific lightning bolt. This value is multiplied against the global lightning probability.")]
		[Range(0f, 1f)]
		public float strikeProbability;

		[Range(0f, 60f)]
		[Tooltip("Size of the lighting bolt.")]
		public float size;

		[Range(0f, 1f)]
		[Tooltip("The blending weight of the additive lighting bolt effect")]
		public float intensity;
	}
}
