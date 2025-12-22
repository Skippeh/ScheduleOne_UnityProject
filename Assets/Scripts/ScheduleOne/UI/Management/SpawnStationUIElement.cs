namespace ScheduleOne.UI.Management
{
	public class SpawnStationUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		public global::ScheduleOne.StationFramework.MushroomSpawnStation AssignedStation { get; protected set; }

		public void Initialize(global::ScheduleOne.StationFramework.MushroomSpawnStation pack)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
