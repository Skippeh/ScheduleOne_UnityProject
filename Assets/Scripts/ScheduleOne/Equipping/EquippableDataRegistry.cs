namespace ScheduleOne.Equipping
{
	public class EquippableDataRegistry : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Equipping.EquippableDataRegistry>
	{
		[ReadOnly]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Core.Equipping.Framework.EquippableData> _equippableDataList;

		public global::ScheduleOne.Core.Equipping.Framework.EquippableData GetEquippableData(global::System.Guid guid)
		{
			return null;
		}

		private void RegisterEquippableData(global::ScheduleOne.Core.Equipping.Framework.EquippableData data)
		{
		}
	}
}
