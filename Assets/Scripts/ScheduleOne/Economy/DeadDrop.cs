namespace ScheduleOne.Economy
{
	public class DeadDrop : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Economy.DeadDrop> DeadDrops;

		public string DeadDropName;

		public string DeadDropDescription;

		public global::ScheduleOne.Map.EMapRegion Region;

		public global::ScheduleOne.Storage.WorldStorageEntity Storage;

		public global::ScheduleOne.Map.POI PoI;

		public global::ScheduleOne.DevUtilities.OptimizedLight Light;

		public string ItemCountVariable;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		public global::System.Guid GUID { get; protected set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		protected virtual void Awake()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Start()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public void OnDestroy()
		{
		}

		public static global::ScheduleOne.Economy.DeadDrop GetRandomEmptyDrop(global::UnityEngine.Vector3 origin)
		{
			return null;
		}

		private void UpdateDeadDrop()
		{
		}
	}
}
