namespace ScheduleOne.Management
{
	public class ConfigurationReplicator : global::FishNet.Object.NetworkBehaviour
	{
		public global::ScheduleOne.Management.EntityConfiguration Configuration;

		private bool NetworkInitialize___EarlyScheduleOne_002EManagement_002EConfigurationReplicatorAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EManagement_002EConfigurationReplicatorAssembly_002DCSharp_002Edll_Excuted;

		public void ReplicateField(global::ScheduleOne.Management.ConfigField field, global::FishNet.Connection.NetworkConnection conn = null)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendItemField(int fieldIndex, string value)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveItemField(int fieldIndex, string value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendNPCField(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveNPCField(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendObjectField(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveObjectField(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendObjectListField(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveObjectListField(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendNumberField(int fieldIndex, float value)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveNumberField(int fieldIndex, float value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendRouteListField(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveRouteListField(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendQualityField(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveQualityField(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendStringField(int fieldIndex, string value)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveStringField(int fieldIndex, string value)
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

		private void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcReader___Server_SendItemField_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcReader___Observers_ReceiveItemField_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcLogic___SendNPCField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SendNPCField_1687693739(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcReader___Observers_ReceiveNPCField_1687693739(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		private void RpcLogic___SendObjectField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		private void RpcReader___Server_SendObjectField_1687693739(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, global::FishNet.Object.NetworkObject obj)
		{
		}

		private void RpcReader___Observers_ReceiveObjectField_1687693739(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		private void RpcLogic___SendObjectListField_690244341(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		private void RpcReader___Server_SendObjectListField_690244341(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objects)
		{
		}

		private void RpcReader___Observers_ReceiveObjectListField_690244341(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcReader___Server_SendRecipeField_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcReader___Observers_ReceiveRecipeField_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcReader___Server_SendNumberField_1293284375(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcReader___Observers_ReceiveNumberField_1293284375(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		private void RpcReader___Server_SendRouteListField_3226448297(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[] value)
		{
		}

		private void RpcReader___Observers_ReceiveRouteListField_3226448297(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}

		private void RpcLogic___SendQualityField_3536682170(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}

		private void RpcReader___Server_SendQualityField_3536682170(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality value)
		{
		}

		private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, global::ScheduleOne.ItemFramework.EQuality value)
		{
		}

		private void RpcReader___Observers_ReceiveQualityField_3536682170(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendStringField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcLogic___SendStringField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcReader___Server_SendStringField_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveStringField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcLogic___ReceiveStringField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcReader___Observers_ReceiveStringField_2801973956(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
