namespace ScheduleOne.Configuration
{
	public class ConfigurationServiceNetworker : global::FishNet.Object.NetworkBehaviour
	{
		private bool NetworkInitialize___EarlyScheduleOne_002EConfiguration_002EConfigurationServiceNetworkerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConfiguration_002EConfigurationServiceNetworkerAssembly_002DCSharp_002Edll_Excuted;

		private global::ScheduleOne.Configuration.ConfigurationService _configurationService => null;

		public override void OnStartServer()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnConfigChanged(global::ScheduleOne.Configuration.BaseConfiguration changedConfig)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void ApplySettingsJson(global::FishNet.Connection.NetworkConnection conn, string configName, string settingsJson)
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

		private void RpcWriter___Observers_ApplySettingsJson_3895153758(global::FishNet.Connection.NetworkConnection conn, string configName, string settingsJson)
		{
		}

		private void RpcLogic___ApplySettingsJson_3895153758(global::FishNet.Connection.NetworkConnection conn, string configName, string settingsJson)
		{
		}

		private void RpcReader___Observers_ApplySettingsJson_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ApplySettingsJson_3895153758(global::FishNet.Connection.NetworkConnection conn, string configName, string settingsJson)
		{
		}

		private void RpcReader___Target_ApplySettingsJson_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
