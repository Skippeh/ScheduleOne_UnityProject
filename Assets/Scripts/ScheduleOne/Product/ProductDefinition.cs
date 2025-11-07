namespace ScheduleOne.Product
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ProductDefinition", menuName = "ScriptableObjects/ProductDefinition", order = 1)]
	public class ProductDefinition : global::ScheduleOne.Product.PropertyItemDefinition, global::ScheduleOne.Persistence.ISaveable
	{
		[global::UnityEngine.Header("Product Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Product.DrugTypeContainer> DrugTypes;

		public float LawIntensityChange;

		public float BasePrice;

		public float MarketValue;

		public global::ScheduleOne.Product.FunctionalProduct FunctionalProduct;

		public int EffectsDuration;

		[global::UnityEngine.Range(0f, 1f)]
		public float BaseAddictiveness;

		[global::UnityEngine.Header("Packaging that can be applied to this product. MUST BE ORDERED FROm LOWEST TO HIGHEST QUANTITY")]
		public global::ScheduleOne.Product.Packaging.PackagingDefinition[] ValidPackaging;

		[global::UnityEngine.Header("Product References")]
		public global::ScheduleOne.Product.FirstPersonProductConsumeAnimation ConsumeAnimation;

		public global::ScheduleOne.Product.EDrugType DrugType => default(global::ScheduleOne.Product.EDrugType);

		public float Price => 0f;

		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> Recipes { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public bool HasChanged { get; set; }

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public void OnValidate()
		{
		}

		public void Initialize(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties, global::System.Collections.Generic.List<global::ScheduleOne.Product.EDrugType> drugTypes)
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public float GetAddictiveness()
		{
			return 0f;
		}

		public void CleanRecipes()
		{
		}

		public void AddRecipe(global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
		}

		public virtual void GenerateAppearanceSettings()
		{
		}

		public virtual global::ScheduleOne.Persistence.Datas.ProductData GetSaveData()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}
	}
}
