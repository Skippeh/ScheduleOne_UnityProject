using UnityEngine;

namespace Funly.SkyStudio
{
	public class TransitionBetweenProfiles : MonoBehaviour
	{
		public SkyProfile daySkyProfile;

		public SkyProfile nightSkyProfile;

		[Tooltip("How long the transition animation will last.")]
		[Range(0.1f, 30f)]
		public float transitionDuration;

		public TimeOfDayController timeOfDayController;

		private SkyProfile m_CurrentSkyProfile;

		private void Start()
		{
		}

		public void ToggleSkyProfiles()
		{
		}
	}
}
