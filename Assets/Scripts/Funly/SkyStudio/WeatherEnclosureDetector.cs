using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		[Tooltip("Default enclosure used when not inside the trigger of another enclosure area.")]
		public WeatherEnclosure mainEnclosure;

		private List<WeatherEnclosure> triggeredEnclosures;

		public RainDownfallController rainController;

		public Action<WeatherEnclosure> enclosureChangedCallback;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void ApplyEnclosure()
		{
		}
	}
}
