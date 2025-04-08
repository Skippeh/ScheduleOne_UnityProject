namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "LiquidMethDefinition", menuName = "ScriptableObjects/LiquidMethDefinition", order = 1)]
	public class LiquidMethDefinition : global::ScheduleOne.ItemFramework.QualityItemDefinition
	{
		[global::UnityEngine.Header("Liquid Meth Color Settings")]
		public global::UnityEngine.Color StaticLiquidColor;

		public global::UnityEngine.Color LiquidVolumeColor;

		public global::UnityEngine.Color PourParticlesColor;

		public global::UnityEngine.Color CookableLiquidColor;

		public global::UnityEngine.Color CookableSolidColor;
	}
}
