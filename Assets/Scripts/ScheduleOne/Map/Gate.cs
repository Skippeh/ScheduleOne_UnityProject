namespace ScheduleOne.Map
{
	public class Gate : global::FishNet.Object.NetworkBehaviour
	{
		public global::UnityEngine.Transform Gate1;

		public global::UnityEngine.Vector3 Gate1Open;

		public global::UnityEngine.Vector3 Gate1Closed;

		public global::UnityEngine.Transform Gate2;

		public global::UnityEngine.Vector3 Gate2Open;

		public global::UnityEngine.Vector3 Gate2Closed;

		public float OpenSpeed;

		public float Acceleration;

		[global::UnityEngine.Header("Sound")]
		public global::ScheduleOne.Audio.AudioSourceController[] StartSounds;

		public global::ScheduleOne.Audio.AudioSourceController[] LoopSounds;

		public global::ScheduleOne.Audio.AudioSourceController[] StopSounds;

		private float Momentum;

		private float openDelta;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002EGateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002EGateAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; protected set; }

		private void Update()
		{
		}

		[global::EasyButtons.Button]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void Open()
		{
		}

		[global::EasyButtons.Button]
		[global::FishNet.Object.ObserversRpc]
		public void Close()
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

		private void RpcWriter___Observers_Open_2166136261()
		{
		}

		public void RpcLogic___Open_2166136261()
		{
		}

		private void RpcReader___Observers_Open_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Close_2166136261()
		{
		}

		public void RpcLogic___Close_2166136261()
		{
		}

		private void RpcReader___Observers_Close_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
