using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public class Fillable : MonoBehaviour
	{
		public class Content
		{
			public string Label;

			public float Volume_L;

			public Color Color;
		}

		[Header("References")]
		public LiquidContainer LiquidContainer;

		[Header("Settings")]
		public bool FillableEnabled;

		public float LiquidCapacity_L;

		public List<Content> contents { get; protected set; }

		private void Awake()
		{
		}

		public void AddLiquid(string label, float volume, Color color)
		{
		}

		public void ResetContents()
		{
		}

		private void UpdateLiquid()
		{
		}

		public float GetLiquidVolume(string label)
		{
			return 0f;
		}

		public float GetTotalLiquidVolume()
		{
			return 0f;
		}
	}
}
