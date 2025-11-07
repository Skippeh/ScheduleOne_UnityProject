namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "WeedDefinition", menuName = "ScriptableObjects/Item Definitions/WeedDefinition", order = 1)]
	public class WeedDefinition : global::ScheduleOne.Product.ProductDefinition
	{
		[global::UnityEngine.Header("Weed Materials")]
		public global::UnityEngine.Material MainMat;

		public global::UnityEngine.Material SecondaryMat;

		public global::UnityEngine.Material LeafMat;

		public global::UnityEngine.Material StemMat;

		private global::ScheduleOne.Product.WeedAppearanceSettings appearance;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties, global::System.Collections.Generic.List<global::ScheduleOne.Product.EDrugType> drugTypes, global::ScheduleOne.Product.WeedAppearanceSettings _appearance)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.ProductData GetSaveData()
		{
			return null;
		}

		public override void GenerateAppearanceSettings()
		{
		}

		private void ApplyAppearanceSettings()
		{
		}

		public static global::ScheduleOne.Product.WeedAppearanceSettings GetAppearanceSettings(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}

		public global::UnityEngine.Material GetMaterial(global::ScheduleOne.Product.WeedAppearanceSettings.EWeedAppearanceType type)
		{
			return null;
		}
	}
}
