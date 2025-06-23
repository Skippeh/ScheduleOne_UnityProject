namespace ScheduleOne.Persistence.Datas
{
	public class JukeboxData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState State;

		public JukeboxData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
