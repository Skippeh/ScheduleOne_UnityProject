namespace ScheduleOne.Equipping
{
	[global::UnityEngine.CreateAssetMenu(fileName = "UmbrellaData", menuName = "ScheduleOne/Equipping/Umbrella")]
	public class EquippableUmbrellaData : global::ScheduleOne.Core.Equipping.Framework.EquippableData
	{
		public global::UnityEngine.Gradient CanopyColor;

		[global::UnityEngine.Header("Canopy Decal")]
		public global::UnityEngine.Texture2D CanopyDecal;

		public global::UnityEngine.Color CanopyDecalColor;
	}
}
