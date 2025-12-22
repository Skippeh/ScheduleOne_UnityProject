namespace ScheduleOne.Map
{
	public class SewerManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Map.SewerManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Serializable]
		public class KeyPossessor
		{
			public global::ScheduleOne.NPCs.NPC NPC;

			[global::UnityEngine.Tooltip("Description of the NPC for Oscar's key location dialogue.")]
			public string NPCDescription;
		}

		public global::ScheduleOne.ItemFramework.ItemDefinition SewerKeyItem;

		public global::ScheduleOne.Audio.AudioSourceController SewerUnlockSound;

		public global::ScheduleOne.ItemFramework.NetworkedItemPickup RandomWorldSewerKeyPickup;

		public global::UnityEngine.Transform[] RandomSewerKeyLocations;

		public global::ScheduleOne.NPCs.CharacterClasses.SewerKing SewerKingNPC;

		public global::ScheduleOne.NPCs.CharacterClasses.SewerGoblin SewerGoblinNPC;

		public global::ScheduleOne.Map.SewerManager.KeyPossessor[] SewerKeyPossessors;

		public global::ScheduleOne.Map.SewerMushrooms SewerMushrooms;

		private global::ScheduleOne.Persistence.Loaders.SewerLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002ESewerManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002ESewerManagerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsSewerUnlocked { get; private set; }

		public bool IsRandomWorldKeyCollected { get; private set; }

		public int RandomSewerKeyLocationIndex { get; set; }

		public bool HasSewerKingBeenDefeated { get; private set; }

		public int RandomSewerPossessorIndex { get; set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetSewerUnlocked_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetSewerUnlocked_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void SetRandomWorldKeyCollected()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetRandomKeyCollected_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetRandomKeyCollected_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetSewerKeyLocation(global::FishNet.Connection.NetworkConnection conn, int locationIndex)
		{
		}

		private void SewerKingDefeated()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void DisableSewerKing(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> GetPlayersInSewer()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.SewerData sewerData)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetRandomKeyPossessor(global::FishNet.Connection.NetworkConnection conn, int possessorIndex)
		{
		}

		private void AskedAboutSewerKey()
		{
		}

		private void EnsureKeyPosessorHasKey()
		{
		}

		public global::ScheduleOne.Map.SewerManager.KeyPossessor GetSewerKeyPossessor()
		{
			return null;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SetSewerUnlocked_Server_2166136261()
		{
		}

		public void RpcLogic___SetSewerUnlocked_Server_2166136261()
		{
		}

		private void RpcReader___Server_SetSewerUnlocked_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSewerUnlocked_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetSewerUnlocked_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetSewerUnlocked_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSewerUnlocked_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetSewerUnlocked_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetRandomKeyCollected_Server_2166136261()
		{
		}

		private void RpcLogic___SetRandomKeyCollected_Server_2166136261()
		{
		}

		private void RpcReader___Server_SetRandomKeyCollected_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetRandomKeyCollected_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetRandomKeyCollected_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetRandomKeyCollected_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetRandomKeyCollected_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetRandomKeyCollected_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSewerKeyLocation_2681120339(global::FishNet.Connection.NetworkConnection conn, int locationIndex)
		{
		}

		private void RpcLogic___SetSewerKeyLocation_2681120339(global::FishNet.Connection.NetworkConnection conn, int locationIndex)
		{
		}

		private void RpcReader___Observers_SetSewerKeyLocation_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSewerKeyLocation_2681120339(global::FishNet.Connection.NetworkConnection conn, int locationIndex)
		{
		}

		private void RpcReader___Target_SetSewerKeyLocation_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_DisableSewerKing_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___DisableSewerKing_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_DisableSewerKing_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_DisableSewerKing_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_DisableSewerKing_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetRandomKeyPossessor_2681120339(global::FishNet.Connection.NetworkConnection conn, int possessorIndex)
		{
		}

		private void RpcLogic___SetRandomKeyPossessor_2681120339(global::FishNet.Connection.NetworkConnection conn, int possessorIndex)
		{
		}

		private void RpcReader___Observers_SetRandomKeyPossessor_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetRandomKeyPossessor_2681120339(global::FishNet.Connection.NetworkConnection conn, int possessorIndex)
		{
		}

		private void RpcReader___Target_SetRandomKeyPossessor_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EMap_002ESewerManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
