using ScheduleOne.NPCs.Responses;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	public class NPCAwareness : MonoBehaviour
	{
		public const float PLAYER_AIM_DETECTION_RANGE = 15f;

		[Header("References")]
		public VisionCone VisionCone;

		public Listener Listener;

		public NPCResponses Responses;

		public UnityEvent<Player> onNoticedGeneralCrime;

		public UnityEvent<Player> onNoticedPettyCrime;

		public UnityEvent<Player> onNoticedDrugDealing;

		public UnityEvent<Player> onNoticedPlayerViolatingCurfew;

		public UnityEvent<Player> onNoticedSuspiciousPlayer;

		public UnityEvent<NoiseEvent> onGunshotHeard;

		public UnityEvent<NoiseEvent> onExplosionHeard;

		public UnityEvent<LandVehicle> onHitByCar;

		private NPC npc;

		protected virtual void Awake()
		{
		}

		public void SetAwarenessActive(bool active)
		{
		}

		public void VisionEvent(VisionEventReceipt vEvent)
		{
		}

		public void NoiseEvent(NoiseEvent nEvent)
		{
		}

		public void HitByCar(LandVehicle vehicle)
		{
		}
	}
}
