using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	[Serializable]
	[CreateAssetMenu(fileName = "LiquidMethDefinition", menuName = "ScriptableObjects/LiquidMethDefinition", order = 1)]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		[Header("Liquid Meth Color Settings")]
		public Color StaticLiquidColor;

		public Color LiquidVolumeColor;

		public Color PourParticlesColor;

		public Color CookableLiquidColor;

		public Color CookableSolidColor;
	}
}
