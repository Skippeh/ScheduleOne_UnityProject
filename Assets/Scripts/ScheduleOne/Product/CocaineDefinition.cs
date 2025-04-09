using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	[Serializable]
	[CreateAssetMenu(fileName = "CocaineDefinition", menuName = "ScriptableObjects/Item Definitions/CocaineDefinition", order = 1)]
	public class CocaineDefinition : ProductDefinition
	{
		[Header("Materials")]
		public Material RockMaterial;

		public CocaineAppearanceSettings AppearanceSettings { get; private set; }

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public void Initialize(List<ScheduleOne.Properties.Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public static CocaineAppearanceSettings GetAppearanceSettings(List<ScheduleOne.Properties.Property> properties)
		{
			return null;
		}
	}
}
