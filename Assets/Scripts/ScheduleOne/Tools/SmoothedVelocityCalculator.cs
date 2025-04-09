using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tools
{
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		public Vector3 Velocity;

		[Header("Settings")]
		public float SampleLength;

		public float MaxReasonableVelocity;

		private List<Tuple<Vector3, float>> VelocityHistory;

		private int maxSamples;

		private Vector3 lastFramePosition;

		private bool zeroOut;

		private void Start()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private Vector3 GetAverageVelocity()
		{
			return default(Vector3);
		}

		public void FlushBuffer()
		{
		}

		public void ZeroOut(float duration)
		{
		}
	}
}
