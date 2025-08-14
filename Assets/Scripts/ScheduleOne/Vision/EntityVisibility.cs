namespace ScheduleOne.Vision
{
	public class EntityVisibility : global::FishNet.Object.NetworkBehaviour
	{
		public const float MAX_VISIBLITY = 100f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisibilityAttribute> ActiveAttributes;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask VisibilityCheckMask;

		[global::UnityEngine.Header("References")]
		public global::System.Collections.Generic.List<global::UnityEngine.Transform> VisibilityPoints;

		private global::ScheduleOne.Vision.VisibilityAttribute environmentalVisibility;

		private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Coroutine> removalRoutinesDict;

		private global::System.Collections.Generic.Dictionary<string, float> maxPointsChangesByUniquenessCode;

		private global::System.Collections.Generic.List<global::UnityEngine.RaycastHit> hits;

		private bool NetworkInitialize___EarlyScheduleOne_002EVision_002EEntityVisibilityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVision_002EEntityVisibilityAssembly_002DCSharp_002Edll_Excuted;

		public float CurrentVisibility { get; protected set; }

		public float Suspiciousness { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Vision.EntityVisualState> VisualStates { get; protected set; }

		public global::UnityEngine.Vector3 CenterPoint => default(global::UnityEngine.Vector3);

		public override void OnStartClient()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private float CalculateVisibility()
		{
			return 0f;
		}

		public global::ScheduleOne.Vision.VisibilityAttribute GetAttribute(string name)
		{
			return null;
		}

		private void UpdateEnvironmentalVisibilityAttribute()
		{
		}

		public float CalculateExposureToPoint(global::UnityEngine.Vector3 point, float checkRange = 50f, global::ScheduleOne.NPCs.NPC checkingNPC = null)
		{
			return 0f;
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void ApplyState(string label, global::ScheduleOne.Vision.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
		}

		public global::ScheduleOne.Vision.EntityVisualState GetState(string label)
		{
			return null;
		}

		public void ClearStates()
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

		private void RpcWriter___Server_ApplyState_2910447583(string label, global::ScheduleOne.Vision.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		public void RpcLogic___ApplyState_2910447583(string label, global::ScheduleOne.Vision.EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		private void RpcReader___Server_ApplyState_2910447583(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		public virtual void Awake()
		{
		}
	}
}
