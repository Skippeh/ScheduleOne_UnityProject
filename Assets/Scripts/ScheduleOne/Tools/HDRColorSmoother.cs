using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tools
{
	[Serializable]
	public class HDRColorSmoother
	{
		[Serializable]
		public class Override
		{
			public Color Value;

			public int Priority;

			public string Label;
		}

		[ColorUsage(true, true)]
		[SerializeField]
		private Color DefaultValue;

		[SerializeField]
		private float SmoothingSpeed;

		[SerializeField]
		private List<Override> overrides;

		public Color CurrentValue { get; private set; }

		public float Multiplier { get; private set; }

		public void Initialize()
		{
		}

		public void Destroy()
		{
		}

		public void SetDefault(Color value)
		{
		}

		public void SetMultiplier(float value)
		{
		}

		public void AddOverride(Color value, int priority, string label)
		{
		}

		public void RemoveOverride(string label)
		{
		}

		public void Update()
		{
		}
	}
}
