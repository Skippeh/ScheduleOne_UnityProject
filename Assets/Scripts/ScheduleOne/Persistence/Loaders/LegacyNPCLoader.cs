namespace ScheduleOne.Persistence.Loaders
{
	public class LegacyNPCLoader : global::ScheduleOne.Persistence.Loaders.Loader
	{
		public virtual string NPCType => null;

		public override void Load(string mainPath)
		{
		}

		protected void TryLoadInventory(string mainPath, global::ScheduleOne.NPCs.NPC npc)
		{
		}
	}
}
