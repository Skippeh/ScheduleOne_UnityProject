namespace ScheduleOne.Trash
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.BoxCollider))]
	public class TrashGenerator : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		public const float TRASH_GENERATION_FRACTION = 0.2f;

		public const float DEFAULT_TRASH_PER_M2 = 0.015f;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashGenerator> AllGenerators;

		[global::UnityEngine.Range(1f, 200f)]
		[global::UnityEngine.SerializeField]
		private int MaxTrashCount;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashItem> generatedTrash;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask GroundCheckMask;

		private global::UnityEngine.BoxCollider boxCollider;

		public string StaticGUID;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public global::System.Guid GUID { get; protected set; }

		public void SetGUID(global::System.Guid guid)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void AddGeneratedTrash(global::ScheduleOne.Trash.TrashItem item)
		{
		}

		public void RemoveGeneratedTrash(global::ScheduleOne.Trash.TrashItem item)
		{
		}

		[global::EasyButtons.Button]
		private void RegenerateGUID()
		{
		}

		[global::EasyButtons.Button]
		private void AutoCalculateTrashCount()
		{
		}

		[global::EasyButtons.Button]
		private void GenerateMaxTrash()
		{
		}

		private void SleepStart()
		{
		}

		private void GenerateTrash(int count)
		{
		}

		public bool ShouldSave()
		{
			return false;
		}

		public virtual global::ScheduleOne.Persistence.Datas.TrashGeneratorData GetSaveData()
		{
			return null;
		}

		public string GetSaveString()
		{
			return null;
		}
	}
}
