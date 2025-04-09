using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	public class CasinoGameController : NetworkBehaviour
	{
		public const float FOV = 65f;

		public const float CAMERA_LERP_TIME = 0.2f;

		[Header("References")]
		public CasinoGamePlayers Players;

		public CasinoGameInteraction Interaction;

		public Transform[] DefaultCameraTransforms;

		protected Transform localDefaultCameraTransform;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECasinoGameControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECasinoGameControllerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; private set; }

		public CasinoGamePlayerData LocalPlayerData => null;

		public virtual void Awake()
		{
		}

		protected virtual void OnLocalPlayerRequestJoin(Player player)
		{
		}

		protected virtual void Exit(ExitAction action)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Open()
		{
		}

		protected virtual void Close()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ECasino_002ECasinoGameController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
