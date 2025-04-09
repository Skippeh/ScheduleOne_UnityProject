using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks.Tasks;

namespace ScheduleOne.PlayerTasks
{
	public class ApplyAdditiveToPot : PourIntoPotTask
	{
		private AdditiveDefinition def;

		protected override bool UseCoverage => false;

		protected override Pot.ECameraPosition CameraPosition => default(Pot.ECameraPosition);

		public ApplyAdditiveToPot(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		protected override void FullyCovered()
		{
		}
	}
}
