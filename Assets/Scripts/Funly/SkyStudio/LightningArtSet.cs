namespace Funly.SkyStudio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "LightningArtSet.asset", menuName = "Sky Studio/Lightning/Lightning Art Set")]
	public class LightningArtSet : global::Funly.SkyStudio.SpriteArtSet
	{
		[global::UnityEngine.Tooltip("List of lighting bolt art that will be used for customization.")]
		public global::System.Collections.Generic.List<global::Funly.SkyStudio.LightningArtItem> lightingStyleItems;
	}
}
