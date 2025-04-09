using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Tools
{
	[ExecuteInEditMode]
	public class WheelRotator : MonoBehaviour
	{
		public float Radius;

		public Transform Wheel;

		public bool Flip;

		public AudioSourceController Controller;

		public float AudioVolumeDivisor;

		public Vector3 RotationAxis;

		[SerializeField]
		private Vector3 lastFramePosition;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
