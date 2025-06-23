namespace ScheduleOne.ObjectScripts
{
	public class SoilPourer : global::ScheduleOne.EntityFramework.GridItem
	{
		public float AnimationDuration;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject HandleIntObj;

		public global::ScheduleOne.Interaction.InteractableObject FillIntObj;

		public global::UnityEngine.MeshRenderer DirtPlane;

		public global::UnityEngine.Transform Dirt_Min;

		public global::UnityEngine.Transform Dirt_Max;

		public global::UnityEngine.ParticleSystem PourParticles;

		public global::UnityEngine.Animation PourAnimation;

		public global::ScheduleOne.Audio.AudioSourceController FillSound;

		public global::ScheduleOne.Audio.AudioSourceController ActivateSound;

		public global::ScheduleOne.Audio.AudioSourceController DirtPourSound;

		private bool isDispensing;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ESoilPourerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ESoilPourerAssembly_002DCSharp_002Edll_Excuted;

		public string SoilID { get; protected set; }

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void HandleHovered()
		{
		}

		public void HandleInteracted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendPourSoil()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void PourSoil()
		{
		}

		private void ApplySoil(string ID)
		{
		}

		public void FillHovered()
		{
		}

		public void FillInteracted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendSoil(string ID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		protected void SetSoil(global::FishNet.Connection.NetworkConnection conn, string ID)
		{
		}

		public void SetSoilLevel(float level)
		{
		}

		protected virtual global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPots()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
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

		private void RpcWriter___Server_SendPourSoil_2166136261()
		{
		}

		private void RpcLogic___SendPourSoil_2166136261()
		{
		}

		private void RpcReader___Server_SendPourSoil_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PourSoil_2166136261()
		{
		}

		private void RpcLogic___PourSoil_2166136261()
		{
		}

		private void RpcReader___Observers_PourSoil_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
		}

		public void RpcLogic___SendSoil_3615296227(string ID)
		{
		}

		private void RpcReader___Server_SendSoil_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSoil_2971853958(global::FishNet.Connection.NetworkConnection conn, string ID)
		{
		}

		protected void RpcLogic___SetSoil_2971853958(global::FishNet.Connection.NetworkConnection conn, string ID)
		{
		}

		private void RpcReader___Observers_SetSoil_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSoil_2971853958(global::FishNet.Connection.NetworkConnection conn, string ID)
		{
		}

		private void RpcReader___Target_SetSoil_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
