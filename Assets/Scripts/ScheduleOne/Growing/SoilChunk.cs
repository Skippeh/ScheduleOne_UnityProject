using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	public class SoilChunk : Clickable
	{
		public Transform EndTransform;

		public float LerpTime;

		private Vector3 localPos_Start;

		private Vector3 localEulerAngles_Start;

		private Vector3 localScale_Start;

		private Coroutine lerpRoutine;

		public float CurrentLerp { get; protected set; }

		protected virtual void Awake()
		{
		}

		public void SetLerpedTransform(float _lerp)
		{
		}

		public override void StartClick(RaycastHit hit)
		{
		}

		public void StopLerp()
		{
		}
	}
}
