using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		[Serializable]
		public class ProductIcon
		{
			public string ProductID;

			public string PackagingID;

			public Sprite Icon;
		}

		[SerializeField]
		private List<ProductIcon> icons;

		[Header("Product and packaging")]
		public IconGenerator IconGenerator;

		public string IconContainerPath;

		public ProductDefinition[] Products;

		public PackagingDefinition[] Packaging;

		public Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			return null;
		}

		public Sprite GenerateIcons(string productID)
		{
			return null;
		}

		private Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			return null;
		}
	}
}
