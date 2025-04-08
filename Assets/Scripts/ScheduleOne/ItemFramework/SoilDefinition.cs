namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "SoilDefinition", menuName = "ScriptableObjects/Item Definitions/SoilDefinition", order = 1)]
	public class SoilDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public enum ESoilQuality
		{
			Basic = 0,
			Premium = 1
		}

		public global::ScheduleOne.ItemFramework.SoilDefinition.ESoilQuality SoilQuality;

		public global::UnityEngine.Material DrySoilMat;

		public global::UnityEngine.Material WetSoilMat;

		public global::UnityEngine.Color ParticleColor;

		public int Uses;
	}
}
