namespace ScheduleOne.Product
{
	public class ProductIconManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Product.ProductIconManager>
	{
		[global::System.Serializable]
		public class ProductIcon
		{
			[global::UnityEngine.HideInInspector]
			public string name;

			public string ProductID;

			public string PackagingID;

			public global::UnityEngine.Sprite Icon;
		}

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductIconManager.ProductIcon> icons;

		[global::UnityEngine.Header("Product and packaging")]
		public global::ScheduleOne.DevUtilities.IconGenerator IconGenerator;

		public string IconContainerPath;

		public global::ScheduleOne.Product.ProductDefinition[] Products;

		public global::ScheduleOne.Product.Packaging.PackagingDefinition[] Packaging;

		public global::UnityEngine.Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			return null;
		}

		public global::UnityEngine.Sprite GenerateIcons(string productID)
		{
			return null;
		}

		private global::UnityEngine.Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			return null;
		}
	}
}
