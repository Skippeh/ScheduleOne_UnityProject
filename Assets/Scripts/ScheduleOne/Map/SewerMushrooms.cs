namespace ScheduleOne.Map
{
	public class SewerMushrooms : global::FishNet.Object.NetworkBehaviour
	{
		[global::System.Serializable]
		public class SewerMushroomSpawnSettings
		{
			public int MaxSpawnAmount;

			[global::UnityEngine.Range(0f, 1f)]
			public float RespawnAmountPerdayAsPercentage;
		}

		[global::UnityEngine.Header("Mushroom Spawning")]
		public global::ScheduleOne.ItemFramework.ItemPickup MushroomObjectPrefab;

		public global::ScheduleOne.Map.SewerMushrooms.SewerMushroomSpawnSettings MushroomSpawnSettings;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> MushroomAreas;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> MushroomLocations;

		[global::UnityEngine.Header("Development & Debugging")]
		[global::UnityEngine.SerializeField]
		private bool _debugMode;

		[global::FishNet.Object.Synchronizing.SyncObject]
		private readonly global::FishNet.Object.Synchronizing.SyncList<int> _activeMushroomLocationIndices;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.ItemFramework.ItemPickup> _spawnedMushroomItems;

		private global::System.Collections.Generic.List<int> _availableMushroomSpawnLocationIndices;

		private global::System.Collections.Generic.List<int> _mushroomSpawnLocationAmountPerArea;

		private int _lastMushroomSpanwnLocationIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002ESewerMushroomsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002ESewerMushroomsAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		private void SetupEvents()
		{
		}

		private void MushroomIndicesChanged(global::FishNet.Object.Synchronizing.SyncListOperation op, int index, int oldItem, int newItem, bool asServer)
		{
		}

		private void SpawnMushroom(int locationIndex)
		{
		}

		private void DespawnMushroom(int locationIndex)
		{
		}

		[global::FishNet.Object.ServerRpc]
		private void SetMushroomSpawnLocationAvailable(int locationIndex)
		{
		}

		private void RegenerateMushrooms()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.SewerData sewerData)
		{
		}

		public global::System.Collections.Generic.List<int> GetActiveMushroomLocationIndices()
		{
			return null;
		}

		private int GetNextSpawnLocation()
		{
			return 0;
		}

		private bool AreLocationsInSameArea(int locationIndexA, int locationIndexB)
		{
			return false;
		}

		private bool CanSpawnMushroom()
		{
			return false;
		}

		private int GetLocationIndex(int index)
		{
			return 0;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
		}

		private void RpcLogic___SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
		}

		private void RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EMap_002ESewerMushrooms_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
