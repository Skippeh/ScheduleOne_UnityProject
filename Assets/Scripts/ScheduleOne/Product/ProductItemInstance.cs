using System;
using FishNet.Serializing.Helping;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		public string PackagingID;

		[CodegenExclude]
		private PackagingDefinition packaging;

		[CodegenExclude]
		public PackagingDefinition AppliedPackaging => null;

		[CodegenExclude]
		public int Amount => 0;

		public override string Name => null;

		[CodegenExclude]
		public override Equippable Equippable => null;

		[CodegenExclude]
		public override StoredItem StoredItem => null;

		[CodegenExclude]
		public override Sprite Icon => null;

		public ProductItemInstance()
		{
		}

		public ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null)
		{
		}

		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public virtual void SetPackaging(PackagingDefinition def)
		{
		}

		private Equippable GetEquippable()
		{
			return null;
		}

		private StoredItem GetStoredItem()
		{
			return null;
		}

		public virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		private Sprite GetIcon()
		{
			return null;
		}

		public override ItemData GetItemData()
		{
			return null;
		}

		public virtual float GetAddictiveness()
		{
			return 0f;
		}

		public float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			return 0f;
		}

		public virtual void ApplyEffectsToNPC(NPC npc)
		{
		}

		public virtual void ClearEffectsFromNPC(NPC npc)
		{
		}

		public virtual void ApplyEffectsToPlayer(Player player)
		{
		}

		public virtual void ClearEffectsFromPlayer(Player Player)
		{
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
