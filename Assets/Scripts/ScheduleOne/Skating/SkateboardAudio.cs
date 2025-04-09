using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Skating
{
	public class SkateboardAudio : MonoBehaviour
	{
		public Skateboard Board;

		[Header("References")]
		public AudioSourceController JumpAudio;

		public AudioSourceController LandAudio;

		public AudioSourceController RollingAudio;

		public AudioSourceController WindAudio;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void PlayJump(float force)
		{
		}

		public void PlayLand()
		{
		}
	}
}
