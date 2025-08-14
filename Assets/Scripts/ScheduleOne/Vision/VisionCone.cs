namespace ScheduleOne.Vision
{
	public class VisionCone : global::FishNet.Object.NetworkBehaviour
	{
		public enum EEventLevel
		{
			Start = 0,
			Half = 1,
			Full = 2,
			Zero = 3
		}

		[global::System.Serializable]
		public class StateContainer
		{
			public global::ScheduleOne.Vision.EVisualState state;

			public bool Enabled;

			public float RequiredNoticeTime;
		}

		public class SightableData
		{
			public global::ScheduleOne.Vision.ISightable Sightable;

			public float VisionDelta;

			public float TimeVisible;
		}

		public delegate void EventStateChange(global::ScheduleOne.Vision.VisionEventReceipt _event);

		public const float VISION_UPDATE_INTERVAL = 0.1f;

		public static float UniversalAttentivenessScale;

		public static float UniversalMemoryScale;

		public bool DEBUG;

		public bool DisableSightUpdates;

		[global::UnityEngine.Header("Frustrum Settings")]
		public float HorizontalFOV;

		public float VerticalFOV;

		public float Range;

		public float MinorWidth;

		public float MinorHeight;

		public global::UnityEngine.Transform VisionOrigin;

		public bool DEBUG_FRUSTRUM;

		[global::UnityEngine.Header("Vision Settings")]
		public bool VisionEnabled;

		public global::UnityEngine.AnimationCurve VisionFalloff;

		public global::UnityEngine.LayerMask VisibilityBlockingLayers;

		[global::UnityEngine.Range(0f, 2f)]
		public float RangeMultiplier;

		[global::UnityEngine.Header("Interest settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisionCone.StateContainer> StatesOfInterest;

		[global::UnityEngine.Header("Notice Settings")]
		public float MinVisionDelta;

		public float Attentiveness;

		public float Memory;

		[global::UnityEngine.Header("Worldspace Icons")]
		public bool WorldspaceIconsEnabled;

		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup QuestionMarkPopup;

		public global::ScheduleOne.UI.WorldspacePopup.WorldspacePopup ExclamationPointPopup;

		public global::ScheduleOne.Audio.AudioSourceController ExclamationSound;

		public global::ScheduleOne.Vision.VisionCone.EventStateChange onVisionEventStarted;

		public global::ScheduleOne.Vision.VisionCone.EventStateChange onVisionEventHalf;

		public global::ScheduleOne.Vision.VisionCone.EventStateChange onVisionEventFull;

		public global::ScheduleOne.Vision.VisionCone.EventStateChange onVisionEventExpired;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vision.ISightable> sightablesOfInterest;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Vision.ISightable, global::ScheduleOne.Vision.VisionCone.SightableData> sightableDatas;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Vision.ISightable, global::System.Collections.Generic.Dictionary<global::ScheduleOne.Vision.EVisualState, global::ScheduleOne.Vision.VisionCone.StateContainer>> stateSettings;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisionEvent> activeVisionEvents;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vision.VisionEvent> cachedVisionEvents;

		protected global::ScheduleOne.NPCs.NPC npc;

		protected bool generalCrimeResponseActive;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vision.ISightable> sightablesSeenThisFrame;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vision.ISightable> toRemove;

		private bool NetworkInitialize___EarlyScheduleOne_002EVision_002EVisionConeAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVision_002EVisionConeAssembly_002DCSharp_002Edll_Excuted;

		protected float effectiveRange => 0f;

		public virtual void Awake()
		{
		}

		private void PlayerSpawned(global::ScheduleOne.PlayerScripts.Player plr)
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void VisionUpdate()
		{
		}

		protected virtual void UpdateEvents(float tickTime)
		{
		}

		protected virtual void UpdateVision(float tickTime)
		{
		}

		public virtual void EventReachedZero(global::ScheduleOne.Vision.VisionEvent _event)
		{
		}

		public virtual void EventHalfNoticed(global::ScheduleOne.Vision.VisionEvent _event)
		{
		}

		public virtual void EventFullyNoticed(global::ScheduleOne.Vision.VisionEvent _event)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEventReceipt(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public virtual void ReceiveEventReceipt(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		public void AddSightableOfInterest(global::ScheduleOne.Vision.ISightable s)
		{
		}

		public void RemoveSightableOfInterest(global::ScheduleOne.Vision.ISightable s)
		{
		}

		public global::ScheduleOne.Vision.VisionCone.StateContainer GetStateSettings(global::ScheduleOne.Vision.ISightable sightable, global::ScheduleOne.Vision.EVisualState state)
		{
			return null;
		}

		public virtual bool IsPointWithinSight(global::UnityEngine.Vector3 point, bool ignoreLoS = false, global::ScheduleOne.Vehicles.LandVehicle vehicleToIgnore = null)
		{
			return false;
		}

		public global::ScheduleOne.Vision.VisionEvent GetEvent(global::ScheduleOne.Vision.ISightable target, global::ScheduleOne.Vision.EntityVisualState state)
		{
			return null;
		}

		public bool IsPlayerVisible(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		public bool WasSightableVisibleThisFrame(global::ScheduleOne.Vision.ISightable sightable)
		{
			return false;
		}

		public bool IsTargetVisible(global::ScheduleOne.Vision.ISightable target)
		{
			return false;
		}

		public float GetPlayerVisibility(global::ScheduleOne.PlayerScripts.Player player)
		{
			return 0f;
		}

		public bool IsPlayerVisible(global::ScheduleOne.PlayerScripts.Player player, out global::ScheduleOne.Vision.VisionCone.SightableData data)
		{
			data = null;
			return false;
		}

		public virtual void SetGeneralCrimeResponseActive(global::ScheduleOne.PlayerScripts.Player player, bool active)
		{
		}

		private void OnDie()
		{
		}

		public void ClearEvents()
		{
		}

		private global::UnityEngine.Vector3[] GetFrustumVertices()
		{
			return null;
		}

		private global::UnityEngine.Plane[] GetFrustumPlanes()
		{
			return null;
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

		private void RpcWriter___Server_SendEventReceipt_3486014028(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		public void RpcLogic___SendEventReceipt_3486014028(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		private void RpcReader___Server_SendEventReceipt_3486014028(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEventReceipt_3486014028(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		public virtual void RpcLogic___ReceiveEventReceipt_3486014028(global::ScheduleOne.Vision.VisionEventReceipt receipt, global::ScheduleOne.Vision.VisionCone.EEventLevel level)
		{
		}

		private void RpcReader___Observers_ReceiveEventReceipt_3486014028(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVision_002EVisionCone_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
