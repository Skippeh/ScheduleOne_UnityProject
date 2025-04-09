using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Audio
{
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoopJukebox : MonoBehaviour
	{
		public AnimationCurve VolumeCurve;

		public List<AudioClip> Clips;

		private AudioSourceController audioSourceController;

		private int currentClipIndex;

		private float musicScale;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void MinPass()
		{
		}
	}
}
