using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet.Object;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne
{
	public class Registry : PersistentSingleton<Registry>
	{
		[Serializable]
		public class ObjectRegister
		{
			public string ID;

			public string AssetPath;

			public NetworkObject Prefab;
		}

		[Serializable]
		public class ItemRegister
		{
			public string ID;

			public string AssetPath;

			public ItemDefinition Definition;
		}

		[SerializeField]
		private List<ObjectRegister> ObjectRegistry;

		[SerializeField]
		private List<ItemRegister> ItemRegistry;

		[SerializeField]
		private List<ItemRegister> ItemsAddedAtRuntime;

		private Dictionary<int, ItemRegister> ItemDictionary;

		public List<SeedDefinition> Seeds;

		protected override void Awake()
		{
		}

		public static GameObject GetPrefab(string id)
		{
			return null;
		}

		public static ItemDefinition GetItem(string ID)
		{
			return null;
		}

		public static T GetItem<T>(string ID) where T : ItemDefinition
		{
			return null;
		}

		public ItemDefinition _GetItem(string ID)
		{
			return null;
		}

		public static Constructable GetConstructable(string id)
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

		public void AddToRegistry(ItemDefinition item)
		{
		}

		private void AddToItemDictionary(ItemRegister reg)
		{
		}

		private void RemoveItemFromDictionary(ItemRegister reg)
		{
		}

		public void RemoveRuntimeItems()
		{
		}

		public void RemoveFromRegistry(ItemDefinition item)
		{
		}

		[Button]
		public void LogOrderedUnlocks()
		{
		}
	}
}
