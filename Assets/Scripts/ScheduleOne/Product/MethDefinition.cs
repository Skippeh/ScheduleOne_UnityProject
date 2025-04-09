using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	[Serializable]
	[CreateAssetMenu(fileName = "MethDefinition", menuName = "ScriptableObjects/Item Definitions/MethDefinition", order = 1)]
	public class MethDefinition : ProductDefinition
	{
		public Material CrystalMaterial;

		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor;

		public MethAppearanceSettings AppearanceSettings { get; private set; }

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public void Initialize(List<ScheduleOne.Properties.Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public static MethAppearanceSettings GetAppearanceSettings(List<ScheduleOne.Properties.Property> properties)
		{
			return null;
		}
	}
}
