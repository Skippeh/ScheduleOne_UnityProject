using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Noise
{
	public class Listener : MonoBehaviour
	{
		public delegate void HearingEvent(NoiseEvent nEvent);

		public static List<Listener> listeners;

		[Header("Settings")]
		[Range(0.1f, 5f)]
		public float Sensitivity;

		public Transform HearingOrigin;

		public HearingEvent onNoiseHeard;

		public float SquaredHearingRange { get; protected set; }

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void Notify(NoiseEvent nEvent)
		{
		}
	}
}
