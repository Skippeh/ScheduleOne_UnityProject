using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	public class VariableDatabase : NetworkSingleton<VariableDatabase>, IBaseSaveable, ISaveable
	{
		public enum EVariableType
		{
			Bool = 0,
			Number = 1
		}

		public List<BaseVariable> VariableList;

		public Dictionary<string, BaseVariable> VariableDict;

		private List<string> playerVariables;

		public VariableCreator[] Creators;

		public StorableItemDefinition[] ItemsToTrackAcquire;

		private VariablesLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EVariables_002EVariableDatabaseAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVariables_002EVariableDatabaseAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		private void CreateVariables()
		{
		}

		public void CreatePlayerVariables(Player owner)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void CreateVariable(string name, EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)
		{
		}

		public void AddVariable(BaseVariable variable)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(NetworkConnection conn, string variableName, string value)
		{
		}

		[ObserversRpc]
		[TargetRpc]
		public void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		public T GetValue<T>(string variableName)
		{
			return default(T);
		}

		[Button]
		public void PrintAllVariables()
		{
		}

		public void PrintVariableValue(string variableName)
		{
		}

		public void NotifyItemAcquired(string id, int quantity)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public void Load(VariableData data)
		{
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

		private void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		public void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		public void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVariables_002EVariableDatabase_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
