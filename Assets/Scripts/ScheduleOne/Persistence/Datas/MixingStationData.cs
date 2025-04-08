namespace ScheduleOne.Persistence.Datas
{
	public class MixingStationData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet ProductContents;

		public global::ScheduleOne.Persistence.Datas.ItemSet MixerContents;

		public global::ScheduleOne.Persistence.Datas.ItemSet OutputContents;

		public global::ScheduleOne.ObjectScripts.MixOperation CurrentMixOperation;

		public int CurrentMixTime;

		public MixingStationData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet productContents, global::ScheduleOne.Persistence.Datas.ItemSet mixerContents, global::ScheduleOne.Persistence.Datas.ItemSet outputContents, global::ScheduleOne.ObjectScripts.MixOperation currentMixOperation, int currentMixTime)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
