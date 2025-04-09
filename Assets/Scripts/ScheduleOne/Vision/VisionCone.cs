using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Vision
{
	public class VisionCone : NetworkBehaviour
	{
		public enum EEventLevel
		{
			Start = 0,
			Half = 1,
			Full = 2,
			Zero = 3
		}

		[Serializable]
		public class StateContainer
		{
			public PlayerVisualState.EVisualState state;

			public bool Enabled;

			public float RequiredNoticeTime;
		}

		public class PlayerSightData
		{
			public Player Player;

			public float VisionDelta;

			public float TimeVisible;
		}

		public delegate void EventStateChange(VisionEventReceipt _event);

		public const float VISION_UPDATE_INTERVAL = 0.1f;

		public static float UniversalAttentivenessScale;

		public static float UniversalMemoryScale;

		public bool DisableSightUpdates;

		[Header("Frustrum Settings")]
		public float HorizontalFOV;

		public float VerticalFOV;

		public float Range;

		public float MinorWidth;

		public float MinorHeight;

		public Transform VisionOrigin;

		public bool DEBUG_FRUSTRUM;

		[Header("Vision Settings")]
		public bool VisionEnabled;

		public AnimationCurve VisionFalloff;

		public LayerMask VisibilityBlockingLayers;

		[Range(0f, 2f)]
		public float RangeMultiplier;

		[Header("Interest settings")]
		public List<StateContainer> StatesOfInterest;

		[Header("Notice Settings")]
		public float MinVisionDelta;

		public float Attentiveness;

		public float Memory;

		[Header("Worldspace Icons")]
		public bool WorldspaceIconsEnabled;

		public WorldspacePopup QuestionMarkPopup;

		public WorldspacePopup ExclamationPointPopup;

		public AudioSourceController ExclamationSound;

		public EventStateChange onVisionEventStarted;

		public EventStateChange onVisionEventHalf;

		public EventStateChange onVisionEventFull;

		public EventStateChange onVisionEventExpired;

		public Dictionary<Player, Dictionary<PlayerVisualState.EVisualState, StateContainer>> StateSettings;

		protected List<VisionEvent> activeVisionEvents;

		protected Dictionary<Player, PlayerSightData> playerSightDatas;

		protected NPC npc;

		private bool generalCrimeResponseActive;

		private List<Player> sightedPlayers;

		private bool NetworkInitialize___EarlyScheduleOne_002EVision_002EVisionConeAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVision_002EVisionConeAssembly_002DCSharp_002Edll_Excuted;

		protected float effectiveRange => 0f;

		public virtual void Awake()
		{
		}

		private void PlayerSpawned(Player plr)
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

		public virtual void EventReachedZero(VisionEvent _event)
		{
		}

		public virtual void EventHalfNoticed(VisionEvent _event)
		{
		}

		public virtual void EventFullyNoticed(VisionEvent _event)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEventReceipt(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public virtual void ReceiveEventReceipt(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		public virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, LandVehicle vehicleToIgnore = null)
		{
			return false;
		}

		public VisionEvent GetEvent(Player target, PlayerVisualState.VisualState state)
		{
			return null;
		}

		public bool IsPlayerVisible(Player player)
		{
			return false;
		}

		public float GetPlayerVisibility(Player player)
		{
			return 0f;
		}

		public bool IsPlayerVisible(Player player, out PlayerSightData data)
		{
			data = null;
			return false;
		}

		public virtual void SetGeneralCrimeResponseActive(Player player, bool active)
		{
		}

		private void OnDie()
		{
		}

		public void ClearEvents()
		{
		}

		private Vector3[] GetFrustumVertices()
		{
			return null;
		}

		private Plane[] GetFrustumPlanes()
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

		private void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		public void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		private void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		public virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, EEventLevel level)
		{
		}

		private void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVision_002EVisionCone_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
