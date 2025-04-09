using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tools
{
	[Serializable]
	public class FloatSmoother
	{
		public class Override
		{
			public float Value;

			public int Priority;

			public string Label;
		}

		[SerializeField]
		private float DefaultValue;

		[SerializeField]
		private float SmoothingSpeed;

		private List<Override> overrides;

		public float CurrentValue { get; private set; }

		public float Multiplier { get; private set; }

		public void Initialize()
		{
		}

		public void Destroy()
		{
		}

		public void SetDefault(float value)
		{
		}

		public void SetMultiplier(float value)
		{
		}

		public void SetSmoothingSpeed(float value)
		{
		}

		public void AddOverride(float value, int priority, string label)
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
