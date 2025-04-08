namespace Funly.SkyStudio
{
	public class RainSplashController : global::UnityEngine.MonoBehaviour, global::Funly.SkyStudio.ISkyModule
	{
		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private global::System.Collections.Generic.List<global::Funly.SkyStudio.RainSplashRenderer> m_SplashRenderers;

		private void Start()
		{
		}

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay)
		{
		}

		private void Update()
		{
		}

		public void ClearSplashRenderers()
		{
		}

		public void CreateSplashRenderers()
		{
		}
	}
}
