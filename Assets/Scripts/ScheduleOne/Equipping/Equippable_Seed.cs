using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Equipping
{
	public class Equippable_Seed : Equippable_Viewmodel
	{
		public SeedDefinition Seed;

		protected override void Update()
		{
		}

		protected virtual void StartSowSeedTask(Pot pot)
		{
		}
	}
}
