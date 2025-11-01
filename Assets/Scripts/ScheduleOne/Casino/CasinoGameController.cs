namespace ScheduleOne.Casino
{
	public class CasinoGameController : global::FishNet.Object.NetworkBehaviour
	{
		public const float FOV = 65f;

		public const float CAMERA_LERP_TIME = 0.2f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Casino.CasinoGamePlayers Players;

		public global::ScheduleOne.Casino.CasinoGameInteraction Interaction;

		public global::UnityEngine.Transform[] DefaultCameraTransforms;

		protected global::UnityEngine.Transform localDefaultCameraTransform;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECasinoGameControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECasinoGameControllerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; private set; }

		public global::ScheduleOne.Casino.CasinoGamePlayerData LocalPlayerData => null;

		public virtual void Awake()
		{
		}

		protected virtual void OnLocalPlayerRequestJoin(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		protected virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
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
