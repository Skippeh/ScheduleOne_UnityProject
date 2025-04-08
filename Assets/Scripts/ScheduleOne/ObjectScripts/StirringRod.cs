namespace ScheduleOne.ObjectScripts
{
	public class StirringRod : global::UnityEngine.MonoBehaviour
	{
		public const float MAX_STIR_RATE = 20f;

		public const float MAX_PIVOT_ANGLE = 7f;

		public float LerpSpeed;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerTasks.Clickable Clickable;

		public global::UnityEngine.Transform PlaneNormal;

		public global::UnityEngine.Transform Container;

		public global::UnityEngine.Transform RodPivot;

		public global::ScheduleOne.Audio.AudioSourceController StirSound;

		private global::UnityEngine.Vector3 clickOffset;

		private bool isMoving;

		public bool Interactable { get; private set; }

		public float CurrentStirringSpeed { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetInteractable(bool e)
		{
		}

		public void ClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		private global::UnityEngine.Vector3 GetPlaneHit()
		{
			return default(global::UnityEngine.Vector3);
		}

		public void ClickEnd()
		{
		}

		public void Destroy()
		{
		}
	}
}
