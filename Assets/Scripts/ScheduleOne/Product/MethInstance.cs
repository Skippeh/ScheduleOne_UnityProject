using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Product
{
	[Serializable]
	public class MethInstance : ProductItemInstance
	{
		public MethInstance()
		{
		}

		public MethInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
		}

		public override ItemData GetItemData()
		{
			return null;
		}

		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		public override void ClearEffectsFromPlayer(Player Player)
		{
		}
	}
}
