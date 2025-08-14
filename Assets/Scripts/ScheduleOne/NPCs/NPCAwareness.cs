namespace ScheduleOne.NPCs
{
	public class NPCAwareness : global::UnityEngine.MonoBehaviour
	{
		public const float PLAYER_AIM_DETECTION_RANGE = 15f;

		public bool AwarenessActiveByDefault;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Vision.VisionCone VisionCone;

		public global::ScheduleOne.Noise.Listener Listener;

		public global::ScheduleOne.NPCs.Responses.NPCResponses Responses;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onNoticedGeneralCrime;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onNoticedPettyCrime;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onNoticedDrugDealing;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onNoticedPlayerViolatingCurfew;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onNoticedSuspiciousPlayer;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Noise.NoiseEvent> onGunshotHeard;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Noise.NoiseEvent> onExplosionHeard;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Vehicles.LandVehicle> onHitByCar;

		private global::ScheduleOne.NPCs.NPC npc;

		protected virtual void Awake()
		{
		}

		public void SetAwarenessActive(bool active)
		{
		}

		public void VisionEvent(global::ScheduleOne.Vision.VisionEventReceipt vEvent)
		{
		}

		public void NoiseEvent(global::ScheduleOne.Noise.NoiseEvent nEvent)
		{
		}

		public void HitByCar(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}
	}
}
