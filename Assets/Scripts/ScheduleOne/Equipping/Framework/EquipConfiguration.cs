namespace ScheduleOne.Equipping.Framework
{
	[global::UnityEngine.CreateAssetMenu(fileName = "EquipConfiguration", menuName = "ScheduleOne/Configurations/EquipConfiguration", order = 1)]
	public class EquipConfiguration : global::ScheduleOne.Configuration.Configuration<global::ScheduleOne.Core.Settings.EquipSettings>
	{
		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.Equipping.EquippedItemHandler[] Handlers;

		public bool TryGetHandlerForData(global::System.Type handlerType, out global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler handler)
		{
			handler = null;
			return false;
		}
	}
}
