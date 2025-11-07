namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class MethInstance : global::ScheduleOne.Product.ProductItemInstance
	{
		public MethInstance()
		{
		}

		public MethInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality, global::ScheduleOne.Product.Packaging.PackagingDefinition packaging = null)
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
