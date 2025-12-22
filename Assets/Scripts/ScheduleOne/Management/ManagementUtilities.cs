namespace ScheduleOne.Management
{
	public class ManagementUtilities : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Management.ManagementUtilities>
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Growing.SeedDefinition> Seeds;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ShroomSpawnDefinition> MushroomSpawns;

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Sprite StorageTypeIcon { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.UI.Management.StorageUIElement StorageUIElementPrefab { get; private set; }

		protected override void Awake()
		{
		}
	}
}
