using System.Collections.Generic;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerDetector : MonoBehaviour
	{
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		public bool DetectPlayerInVehicle;

		public UnityEvent<Player> onPlayerEnter;

		public UnityEvent<Player> onPlayerExit;

		public UnityEvent onLocalPlayerEnter;

		public UnityEvent onLocalPlayerExit;

		public List<Player> DetectedPlayers;

		private bool ignoreExit;

		private bool collidersEnabled;

		private Collider[] detectionColliders;

		public bool IgnoreNewDetections { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void MinPass()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void SetIgnoreNewCollisions(bool ignore)
		{
		}
	}
}
