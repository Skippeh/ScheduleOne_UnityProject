namespace ScheduleOne.Variables
{
	public class VariableDatabase : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Variables.VariableDatabase>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public enum EVariableType
		{
			Bool = 0,
			Number = 1
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Variables.BaseVariable> VariableList;

		public global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Variables.BaseVariable> VariableDict;

		private global::System.Collections.Generic.List<string> playerVariables;

		public global::ScheduleOne.Variables.VariableCreator[] Creators;

		public global::ScheduleOne.ItemFramework.StorableItemDefinition[] ItemsToTrackAcquire;

		private global::ScheduleOne.Persistence.Loaders.VariablesLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EVariables_002EVariableDatabaseAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVariables_002EVariableDatabaseAssembly_002DCSharp_002Edll_Excuted;

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

		public virtual void InitializeSaveable()
		{
		}

		private void CreateVariables()
		{
		}

		public void CreatePlayerVariables(global::ScheduleOne.PlayerScripts.Player owner)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void CreateVariable(string name, global::ScheduleOne.Variables.VariableDatabase.EVariableType type, string initialValue, bool persistent, global::ScheduleOne.Variables.EVariableMode mode, global::ScheduleOne.PlayerScripts.Player owner, global::ScheduleOne.Variables.EVariableReplicationMode replicationMode = global::ScheduleOne.Variables.EVariableReplicationMode.Networked)
		{
		}

		public void AddVariable(global::ScheduleOne.Variables.BaseVariable variable)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		public void ReceiveValue(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		public global::ScheduleOne.Variables.BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		public T GetValue<T>(string variableName)
		{
			return default(T);
		}

		[global::EasyButtons.Button]
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

		public void LoadVariable(global::ScheduleOne.Persistence.Datas.VariableData data)
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

		private void RpcWriter___Server_SendValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		public void RpcLogic___SendValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Server_SendValue_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		public void RpcLogic___ReceiveValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Observers_ReceiveValue_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Target_ReceiveValue_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVariables_002EVariableDatabase_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
