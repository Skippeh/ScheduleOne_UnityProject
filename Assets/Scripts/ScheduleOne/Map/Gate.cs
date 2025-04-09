using EasyButtons;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class Gate : MonoBehaviour
	{
		public Transform Gate1;

		public Vector3 Gate1Open;

		public Vector3 Gate1Closed;

		public Transform Gate2;

		public Vector3 Gate2Open;

		public Vector3 Gate2Closed;

		public float OpenSpeed;

		public float Acceleration;

		[Header("Sound")]
		public AudioSourceController[] StartSounds;

		public AudioSourceController[] LoopSounds;

		public AudioSourceController[] StopSounds;

		private float Momentum;

		private float openDelta;

		public bool IsOpen { get; protected set; }

		private void Update()
		{
		}

		[Button]
		public void Open()
		{
		}

		[Button]
		public void Close()
		{
		}
	}
}
