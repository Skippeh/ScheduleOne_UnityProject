namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class CocaineInstance : global::ScheduleOne.Product.ProductItemInstance
	{
		private const float WorkSpeedMultiplier = 1.2f;

		public CocaineInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality, global::ScheduleOne.Product.Packaging.PackagingDefinition packaging = null)
			: base(null, 0, default(global::ScheduleOne.ItemFramework.EQuality))
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public override void ApplyEffectsToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ClearEffectsFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ApplyEffectsToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void ClearEffectsFromPlayer(global::ScheduleOne.PlayerScripts.Player Player)
		{
		}
	}
}
