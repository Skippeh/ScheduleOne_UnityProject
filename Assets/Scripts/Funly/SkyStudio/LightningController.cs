using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	public class LightningController : MonoBehaviour, ISkyModule
	{
		private SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private List<LightningRenderer> m_LightningRenderers;

		private void Start()
		{
		}

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
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
