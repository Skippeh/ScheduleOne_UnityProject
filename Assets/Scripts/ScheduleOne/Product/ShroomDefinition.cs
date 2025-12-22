namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ShroomDefinition", menuName = "ScriptableObjects/Item Definitions/ShroomDefinition", order = 1)]
	public class ShroomDefinition : global::ScheduleOne.Product.ProductDefinition
	{
		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Material ShroomMaterial { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Material BulkMaterial { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Material EyeballMaterial { get; private set; }

		public global::ScheduleOne.Product.ShroomAppearanceSettings AppearanceSettings { get; private set; }

		public override void ValidateDefinition()
		{
		}

		public void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties, global::System.Collections.Generic.List<global::ScheduleOne.Product.EDrugType> drugTypes, global::ScheduleOne.Product.ShroomAppearanceSettings _appearance)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ProductData GetSaveData()
		{
			return null;
		}

		public override void GenerateAppearanceSettings()
		{
		}

		private void GenerateMaterials()
		{
		}

		public static global::ScheduleOne.Product.ShroomAppearanceSettings GetAppearanceSettings(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}
	}
}
