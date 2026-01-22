namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class ProductItemInstance : global::ScheduleOne.ItemFramework.QualityItemInstance
	{
		public string PackagingID;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		private global::ScheduleOne.Product.Packaging.PackagingDefinition packaging;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.Product.Packaging.PackagingDefinition AppliedPackaging => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public int Amount => 0;

		public override string Name => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public override global::ScheduleOne.Equipping.Equippable Equippable => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public override global::ScheduleOne.Storage.StoredItem StoredItem => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public override global::UnityEngine.Sprite Icon => null;

		public ProductItemInstance()
		{
		}

		public ProductItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality, global::ScheduleOne.Product.Packaging.PackagingDefinition _packaging = null)
		{
		}

		public override bool CanStackWith(global::ScheduleOne.ItemFramework.ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public virtual void SetPackaging(global::ScheduleOne.Product.Packaging.PackagingDefinition def)
		{
		}

		private global::ScheduleOne.Equipping.Equippable GetEquippable()
		{
			return null;
		}

		private global::ScheduleOne.Storage.StoredItem GetStoredItem()
		{
			return null;
		}

		private global::UnityEngine.Sprite GetIcon()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public virtual float GetAddictiveness()
		{
			return 0f;
		}

		public float GetSimilarity(global::ScheduleOne.Product.ProductDefinition other, global::ScheduleOne.ItemFramework.EQuality otherQuality)
		{
			return 0f;
		}

		public virtual void ApplyEffectsToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual void ClearEffectsFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual void ApplyEffectsToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void ClearEffectsFromPlayer(global::ScheduleOne.PlayerScripts.Player Player)
		{
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}

		public override int GetTotalAmount()
		{
			return 0;
		}
	}
}
