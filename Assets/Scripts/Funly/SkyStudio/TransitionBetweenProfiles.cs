namespace Funly.SkyStudio
{
	public class TransitionBetweenProfiles : global::UnityEngine.MonoBehaviour
	{
		public global::Funly.SkyStudio.SkyProfile daySkyProfile;

		public global::Funly.SkyStudio.SkyProfile nightSkyProfile;

		[global::UnityEngine.Tooltip("How long the transition animation will last.")]
		[global::UnityEngine.Range(0.1f, 30f)]
		public float transitionDuration;

		public global::Funly.SkyStudio.TimeOfDayController timeOfDayController;

		private global::Funly.SkyStudio.SkyProfile m_CurrentSkyProfile;

		private void Start()
		{
		}

		public void ToggleSkyProfiles()
		{
		}
	}
}
