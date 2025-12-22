namespace ScheduleOne.Equipping
{
	public class PourableWaterContainerEquipped : global::ScheduleOne.Equipping.Equippable_Pourable
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.WaterContainerVisualizer _visuals;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerScripts.WaterContainerPourable _pourablePrefab;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _waterContainerInstance;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override bool CanPour(global::ScheduleOne.Growing.GrowContainer growContainer, out string reason)
		{
			reason = null;
			return false;
		}

		protected override void StartPourTask(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
		}
	}
}
