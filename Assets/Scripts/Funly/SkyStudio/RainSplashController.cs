using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	public class RainSplashController : MonoBehaviour, ISkyModule
	{
		private SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private List<RainSplashRenderer> m_SplashRenderers;

		private void Start()
		{
		}

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
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
