namespace Funly.SkyStudio
{
	public class LightningController : global::UnityEngine.MonoBehaviour, global::Funly.SkyStudio.ISkyModule
	{
		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private global::System.Collections.Generic.List<global::Funly.SkyStudio.LightningRenderer> m_LightningRenderers;

		private void Start()
		{
		}

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay)
		{
		}

		public void Update()
		{
		}

		public void ClearLightningRenderers()
		{
		}

		public void CreateLightningRenderers()
		{
		}
	}
}
