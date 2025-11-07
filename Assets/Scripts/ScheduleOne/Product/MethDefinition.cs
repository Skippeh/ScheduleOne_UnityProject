namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "MethDefinition", menuName = "ScriptableObjects/Item Definitions/MethDefinition", order = 1)]
	public class MethDefinition : global::ScheduleOne.Product.ProductDefinition
	{
		public global::UnityEngine.Material CrystalMaterial;

		[global::UnityEngine.ColorUsage(true, true)]
		[global::UnityEngine.SerializeField]
		public global::UnityEngine.Color TintColor;

		public global::ScheduleOne.Product.MethAppearanceSettings AppearanceSettings { get; private set; }

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties, global::System.Collections.Generic.List<global::ScheduleOne.Product.EDrugType> drugTypes, global::ScheduleOne.Product.MethAppearanceSettings _appearance)
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

		public static global::ScheduleOne.Product.MethAppearanceSettings GetAppearanceSettings(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}
	}
}
