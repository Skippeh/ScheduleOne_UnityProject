namespace Funly.SkyStudio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "lightningArtItem.asset", menuName = "Sky Studio/Lightning/Lightning Art Item")]
	public class LightningArtItem : global::Funly.SkyStudio.SpriteArtItem
	{
		public enum Alignment
		{
			ScaleToFit = 0,
			TopAlign = 1
		}

		[global::UnityEngine.Tooltip("Adjust how the lightning bolt is positioned inside the spawn area container.")]
		public global::Funly.SkyStudio.LightningArtItem.Alignment alignment;

		[global::UnityEngine.Tooltip("Thunder sound clip to play when this lighting bolt is rendered.")]
		public global::UnityEngine.AudioClip thunderSound;

		[global::UnityEngine.Tooltip("Probability adjustment for this specific lightning bolt. This value is multiplied against the global lightning probability.")]
		[global::UnityEngine.Range(0f, 1f)]
		public float strikeProbability;

		[global::UnityEngine.Range(0f, 60f)]
		[global::UnityEngine.Tooltip("Size of the lighting bolt.")]
		public float size;

		[global::UnityEngine.Range(0f, 1f)]
		[global::UnityEngine.Tooltip("The blending weight of the additive lighting bolt effect")]
		public float intensity;
	}
}
