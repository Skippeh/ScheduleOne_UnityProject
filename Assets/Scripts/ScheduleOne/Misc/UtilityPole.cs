using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Misc
{
	public class UtilityPole : MonoBehaviour
	{
		public const float CABLE_CULL_DISTANCE = 100f;

		public const float CABLE_CULL_DISTANCE_SQR = 10000f;

		public UtilityPole previousPole;

		public UtilityPole nextPole;

		public bool Connection1Enabled;

		public bool Connection2Enabled;

		public float LengthFactor;

		[Header("References")]
		public Transform cable1Connection;

		public Transform cable2Connection;

		public List<Transform> cable1Segments;

		public List<Transform> cable2Segments;

		public Transform Cable1Container;

		public Transform Cable2Container;

		private Vector3 cableStart;

		private Vector3 cableEnd;

		private Vector3 cableMid;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void UpdateCulling()
		{
		}

		[Button]
		public void Orient()
		{
		}

		[Button]
		public void DrawLines()
		{
		}
	}
}
