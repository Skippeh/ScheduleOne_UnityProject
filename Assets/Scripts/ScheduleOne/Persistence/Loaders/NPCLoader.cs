using ScheduleOne.NPCs;

namespace ScheduleOne.Persistence.Loaders
{
	public class NPCLoader : Loader
	{
		public virtual string NPCType => null;

		public override void Load(string mainPath)
		{
		}

		protected void TryLoadInventory(string mainPath, NPC npc)
		{
		}
	}
}
