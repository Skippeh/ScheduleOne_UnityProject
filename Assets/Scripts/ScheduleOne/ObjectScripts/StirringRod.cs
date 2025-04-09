using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class StirringRod : MonoBehaviour
	{
		public const float MAX_STIR_RATE = 20f;

		public const float MAX_PIVOT_ANGLE = 7f;

		public float LerpSpeed;

		[Header("References")]
		public Clickable Clickable;

		public Transform PlaneNormal;

		public Transform Container;

		public Transform RodPivot;

		public AudioSourceController StirSound;

		private Vector3 clickOffset;

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

		public void ClickStart(RaycastHit hit)
		{
		}

		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		public void ClickEnd()
		{
		}

		public void Destroy()
		{
		}
	}
}
