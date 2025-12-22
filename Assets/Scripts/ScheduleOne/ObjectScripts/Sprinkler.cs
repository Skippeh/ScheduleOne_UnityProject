namespace ScheduleOne.ObjectScripts
{
	public class Sprinkler : global::ScheduleOne.EntityFramework.GridItem
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.ParticleSystem[] WaterParticles;

		public global::ScheduleOne.Audio.AudioSourceController ClickSound;

		public global::ScheduleOne.Audio.AudioSourceController WaterSound;

		[global::UnityEngine.Header("Settings")]
		public float ApplyWaterDelay;

		public float ParticleStopDelay;

		public global::UnityEngine.Events.UnityEvent onSprinklerStart;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ESprinklerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ESprinklerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsSprinkling { get; private set; }

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanWater()
		{
			return false;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendWater()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Water()
		{
		}

		public void AddWater(float normalizedAmount)
		{
		}

		protected virtual global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPots()
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

		private void RpcWriter___Server_SendWater_2166136261()
		{
		}

		private void RpcLogic___SendWater_2166136261()
		{
		}

		private void RpcReader___Server_SendWater_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Water_2166136261()
		{
		}

		private void RpcLogic___Water_2166136261()
		{
		}

		private void RpcReader___Observers_Water_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
