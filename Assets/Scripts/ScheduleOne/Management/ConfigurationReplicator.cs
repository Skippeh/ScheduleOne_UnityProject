using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	public class ConfigurationReplicator : NetworkBehaviour
	{
		public EntityConfiguration Configuration;

		private bool NetworkInitialize___EarlyScheduleOne_002EManagement_002EConfigurationReplicatorAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EManagement_002EConfigurationReplicatorAssembly_002DCSharp_002Edll_Excuted;

		public void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendItemField(int fieldIndex, string value)
		{
		}

		[ObserversRpc]
		private void ReceiveItemField(int fieldIndex, string value)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		[ObserversRpc]
		private void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		[ObserversRpc]
		private void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		[ObserversRpc]
		private void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		[ObserversRpc]
		private void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendNumberField(int fieldIndex, float value)
		{
		}

		[ObserversRpc]
		private void ReceiveNumberField(int fieldIndex, float value)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		[ObserversRpc]
		private void ReceiveRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendQualityField(int fieldIndex, EQuality quality)
		{
		}

		[ObserversRpc]
		private void ReceiveQualityField(int fieldIndex, EQuality value)
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

		private void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		private void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		private void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		private void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		private void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		private void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		private void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		private void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		private void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		private void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		private void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		private void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		private void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		private void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		private void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		private void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		private void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
