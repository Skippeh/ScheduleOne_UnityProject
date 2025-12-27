namespace ScheduleOne.Growing
{
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Component.Transforming.NetworkTransform))]
	public class ShroomColony : global::FishNet.Object.NetworkBehaviour
	{
		public const float MaxTemperatureForGrowth = 15f;

		private const float MinSoilMoistureForGrowth = 0.0001f;

		private const float RandomRotationRange = 15f;

		private const float RandomVerticalShift = 0.02f;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.ItemFramework.ShroomSpawnDefinition _spawnDefinition;

		[global::UnityEngine.SerializeField]
		private int _growTime;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform[] _shroomAlignments;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Growing.GrowingMushroom[] _growingShroomPrefabs;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _snipSound;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem _fullyGrownParticles;

		public global::System.Action onFullyHarvested;

		private global::System.Collections.Generic.List<global::ScheduleOne.Growing.GrowingMushroom> _growingShrooms;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Growing.GrowingMushroom, int> _growingShroomPositions;

		private global::System.Collections.Generic.List<int> _takenAlignmentIndices;

		private global::ScheduleOne.ObjectScripts.MushroomBed _parentBed;

		private bool _shroomsInitiallySpawned;

		private bool NetworkInitialize___EarlyScheduleOne_002EGrowing_002EShroomColonyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGrowing_002EShroomColonyAssembly_002DCSharp_002Edll_Excuted;

		[field: global::UnityEngine.SerializeField]
		public int BaseShroomYield { get; private set; }

		public float GrowthProgress { get; private set; }

		public bool IsFullyGrown => false;

		public bool IsTooHotToGrow => false;

		public int GrownMushroomCount => 0;

		public global::ScheduleOne.Audio.AudioSourceController SnipSound => null;

		public float NormalizedQuality { get; private set; }

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void OnStartClient()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnMinPass()
		{
		}

		private void OnTimeSkipped(int mins)
		{
		}

		public void SetColonyVisible(bool visible)
		{
		}

		private float GetCurrentGrowthRate()
		{
			return 0f;
		}

		private void ChangeGrowthPercentage(float change)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetFullyGrown()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetGrowthPercentage_Local(global::FishNet.Connection.NetworkConnection conn, float percent)
		{
		}

		private void SetGrowthPercentage(float percent)
		{
		}

		private void ChangeQuality(float change)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddShroomAtPosition_Server(int alignmentIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddShroomAtPosition_Local(int alignmentIndex)
		{
		}

		private void AddShroomAtPosition(int alignmentIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void RemoveShroom_Server(int alignmentIndex)
		{
		}

		public void RemoveRandomShroom()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void RemoveShoom_Client(int alignmentIndex)
		{
		}

		private void RemoveShroom(int alignmentIndex)
		{
		}

		private void RemoveShroom(global::ScheduleOne.Growing.GrowingMushroom shroom)
		{
		}

		public void SetFullyHarvested()
		{
		}

		private int GetRandomAvailableAlignmentIndex()
		{
			return 0;
		}

		public global::ScheduleOne.Product.ShroomInstance GetHarvestedShroom(int quantity = 1)
		{
			return null;
		}

		public void AdditiveApplied(global::ScheduleOne.ItemFramework.AdditiveDefinition additive, bool isInitialApplication)
		{
		}

		[global::FishNet.Object.TargetRpc]
		public void SetColonyState(global::FishNet.Connection.NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		public global::ScheduleOne.Persistence.Datas.ShroomColonyData GetSaveData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.ShroomColonyData data)
		{
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

		private void RpcWriter___Server_SetFullyGrown_2166136261()
		{
		}

		public void RpcLogic___SetFullyGrown_2166136261()
		{
		}

		private void RpcReader___Server_SetFullyGrown_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetGrowthPercentage_Local_530160725(global::FishNet.Connection.NetworkConnection conn, float percent)
		{
		}

		private void RpcLogic___SetGrowthPercentage_Local_530160725(global::FishNet.Connection.NetworkConnection conn, float percent)
		{
		}

		private void RpcReader___Observers_SetGrowthPercentage_Local_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetGrowthPercentage_Local_530160725(global::FishNet.Connection.NetworkConnection conn, float percent)
		{
		}

		private void RpcReader___Target_SetGrowthPercentage_Local_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
		}

		public void RpcLogic___AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
		}

		private void RpcReader___Server_AddShroomAtPosition_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
		}

		private void RpcLogic___AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
		}

		private void RpcReader___Observers_AddShroomAtPosition_Local_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_RemoveShroom_Server_3316948804(int alignmentIndex)
		{
		}

		public void RpcLogic___RemoveShroom_Server_3316948804(int alignmentIndex)
		{
		}

		private void RpcReader___Server_RemoveShroom_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemoveShoom_Client_3316948804(int alignmentIndex)
		{
		}

		private void RpcLogic___RemoveShoom_Client_3316948804(int alignmentIndex)
		{
		}

		private void RpcReader___Observers_RemoveShoom_Client_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetColonyState_4288818029(global::FishNet.Connection.NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		public void RpcLogic___SetColonyState_4288818029(global::FishNet.Connection.NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		private void RpcReader___Target_SetColonyState_4288818029(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
