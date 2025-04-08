namespace ScheduleOne.PlayerScripts
{
	public class PlayerVisualState : global::FishNet.Object.NetworkBehaviour
	{
		public enum EVisualState
		{
			Visible = 0,
			Suspicious = 1,
			DisobeyingCurfew = 2,
			Vandalizing = 3,
			PettyCrime = 4,
			DrugDealing = 5,
			SearchedFor = 6,
			Wanted = 7,
			Pickpocketing = 8,
			DischargingWeapon = 9,
			Brandishing = 10
		}

		[global::System.Serializable]
		public class VisualState
		{
			public global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState state;

			public string label;

			public global::System.Action stateDestroyed;
		}

		public float Suspiciousness;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.PlayerVisualState.VisualState> visualStates;

		private global::ScheduleOne.PlayerScripts.Player player;

		private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Coroutine> removalRoutinesDict;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerVisualStateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerVisualStateAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		private void Update()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void ApplyState(string label, global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
		}

		public global::ScheduleOne.PlayerScripts.PlayerVisualState.VisualState GetState(string label)
		{
			return null;
		}

		public void ClearStates()
		{
		}

		private void UpdateSuspiciousness()
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

		private void RpcWriter___Server_ApplyState_868472085(string label, global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		public void RpcLogic___ApplyState_868472085(string label, global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		private void RpcReader___Server_ApplyState_868472085(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
		}

		public void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
		}

		private void RpcReader___Server_RemoveState_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayerVisualState_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
