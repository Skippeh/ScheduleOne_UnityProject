namespace ScheduleOne
{
	public class Registry : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Registry>
	{
		[global::System.Serializable]
		public class ObjectRegister
		{
			public string ID;

			public string AssetPath;

			public global::FishNet.Object.NetworkObject Prefab;
		}

		[global::System.Serializable]
		public class ItemRegister
		{
			[global::UnityEngine.HideInInspector]
			public string name;

			public string ID;

			public string AssetPath;

			public global::ScheduleOne.ItemFramework.ItemDefinition Definition;
		}

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Registry.ItemRegister> ItemRegistry;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Registry.ItemRegister> ItemsAddedAtRuntime;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.Registry.ItemRegister> ItemDictionary;

		private global::System.Collections.Generic.Dictionary<string, string> itemIDAliases;

		private void OnValidate()
		{
		}

		protected override void Awake()
		{
		}

		public static global::ScheduleOne.ItemFramework.ItemDefinition GetItem(string ID)
		{
			return null;
		}

		public static bool ItemExists(string ID)
		{
			return false;
		}

		public static T GetItem<T>(string ID) where T : global::ScheduleOne.ItemFramework.ItemDefinition
		{
			return null;
		}

		public global::ScheduleOne.ItemFramework.ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			return null;
		}

		private static int GetHash(string ID)
		{
			return 0;
		}

		private static string RemoveAssetsAndPrefab(string originalString)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void AddToRegistry(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemDefinition> GetAllItems()
		{
			return null;
		}

		private void AddToItemDictionary(global::ScheduleOne.Registry.ItemRegister reg)
		{
		}

		private void RemoveItemFromDictionary(global::ScheduleOne.Registry.ItemRegister reg)
		{
		}

		public void RemoveRuntimeItems()
		{
		}

		public void RemoveFromRegistry(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
		}

		[global::EasyButtons.Button]
		public void LogOrderedUnlocks()
		{
		}
	}
}
