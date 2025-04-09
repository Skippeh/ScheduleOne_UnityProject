using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	public class Sensor : MonoBehaviour
	{
		public Collider obstruction;

		public float obstructionDistance;

		public const float checkRate = 0.33f;

		[Header("Settings")]
		[SerializeField]
		protected float minDetectionRange;

		[SerializeField]
		protected float maxDetectionRange;

		public float checkRadius;

		public LayerMask checkMask;

		private LandVehicle vehicle;

		[HideInInspector]
		public float calculatedDetectionRange;

		private RaycastHit hit;

		private List<RaycastHit> hits;

		protected virtual void Start()
		{
		}

		public void Check()
		{
		}
	}
}
