namespace ScheduleOne.Growing
{
	public class SoilChunk : global::ScheduleOne.PlayerTasks.Clickable
	{
		public global::UnityEngine.Transform EndTransform;

		public float LerpTime;

		private global::UnityEngine.Vector3 localPos_Start;

		private global::UnityEngine.Vector3 localEulerAngles_Start;

		private global::UnityEngine.Vector3 localScale_Start;

		private global::UnityEngine.Coroutine lerpRoutine;

		public float CurrentLerp { get; protected set; }

		protected virtual void Awake()
		{
		}

		public void SetLerpedTransform(float _lerp)
		{
		}

		public override void StartClick(global::UnityEngine.RaycastHit hit)
		{
		}

		public void StopLerp()
		{
		}
	}
}
