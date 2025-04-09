using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	[Serializable]
	public class CocaineAppearanceSettings
	{
		public Color32 MainColor;

		public Color32 SecondaryColor;

		public CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
		}

		public CocaineAppearanceSettings()
		{
		}

		public bool IsUnintialized()
		{
			return false;
		}
	}
}
