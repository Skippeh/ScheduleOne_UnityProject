using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	[RequireComponent(typeof(AudioSourceController))]
	public class VOEmitter : MonoBehaviour
	{
		public const float PitchVariation = 0.05f;

		[SerializeField]
		private VODatabase Database;

		[Range(0.5f, 2f)]
		public float PitchMultiplier;

		private float runtimePitchMultiplier;

		protected AudioSourceController audioSourceController;

		private VODatabase defaultVODatabase;

		protected virtual void Awake()
		{
		}

		public virtual void Play(EVOLineType lineType)
		{
		}

		public void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
		}

		public void SetDatabase(VODatabase database, bool writeDefault = true)
		{
		}

		public void ResetDatabase()
		{
		}
	}
}
