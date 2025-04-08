namespace ScheduleOne.StationFramework
{
	public class StationItem : global::UnityEngine.MonoBehaviour
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.ItemModule> Modules;

		public global::ScheduleOne.Trash.TrashItem TrashPrefab;

		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.ItemModule> ActiveModules { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void Initialize(global::ScheduleOne.ItemFramework.StorableItemDefinition itemDefinition)
		{
		}

		public void ActivateModule<T>() where T : global::ScheduleOne.StationFramework.ItemModule
		{
		}

		public void Destroy()
		{
		}

		public bool HasModule<T>() where T : global::ScheduleOne.StationFramework.ItemModule
		{
			return false;
		}

		public T GetModule<T>() where T : global::ScheduleOne.StationFramework.ItemModule
		{
			return null;
		}
	}
}
