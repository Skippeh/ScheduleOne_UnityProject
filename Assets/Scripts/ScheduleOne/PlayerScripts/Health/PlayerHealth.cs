namespace ScheduleOne.PlayerScripts.Health
{
	public class PlayerHealth : global::FishNet.Object.NetworkBehaviour
	{
		public const float MAX_HEALTH = 100f;

		public const float HEALTH_RECOVERY_PER_MINUTE = 0.5f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerScripts.Player Player;

		public global::UnityEngine.Events.UnityEvent<float> onHealthChanged;

		public global::UnityEngine.Events.UnityEvent onDie;

		public global::UnityEngine.Events.UnityEvent onRevive;

		private bool AfflictedWithLethalEffect;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EHealth_002EPlayerHealthAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EHealth_002EPlayerHealthAssembly_002DCSharp_002Edll_Excuted;

		public bool IsAlive { get; protected set; }

		public float CurrentHealth { get; protected set; }

		public float TimeSinceLastDamage { get; protected set; }

		public bool CanTakeDamage => false;

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		private void Update()
		{
		}

		private void MinPass()
		{
		}

		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		public void RecoverHealth(float recovery)
		{
		}

		public void SetHealth(float health)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDie()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void Die()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRevive(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void Revive(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void PlayBloodMist()
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

		private void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		public void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		private void RpcReader___Observers_TakeDamage_3505310624(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendDie_2166136261()
		{
		}

		public void RpcLogic___SendDie_2166136261()
		{
		}

		private void RpcReader___Server_SendDie_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Die_2166136261()
		{
		}

		public void RpcLogic___Die_2166136261()
		{
		}

		private void RpcReader___Observers_Die_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendRevive_3848837105(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		public void RpcLogic___SendRevive_3848837105(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		private void RpcReader___Server_SendRevive_3848837105(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Revive_3848837105(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		public void RpcLogic___Revive_3848837105(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		private void RpcReader___Observers_Revive_3848837105(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
		}

		public void RpcLogic___PlayBloodMist_2166136261()
		{
		}

		private void RpcReader___Observers_PlayBloodMist_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EHealth_002EPlayerHealth_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
