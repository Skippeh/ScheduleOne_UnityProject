using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	public class PourableAdditive : Pourable
	{
		public const float NormalizedAmountForSuccess = 0.8f;

		public AdditiveDefinition AdditiveDefinition;

		public Color LiquidColor;

		private float pouredAmount;

		protected override void PourAmount(float amount)
		{
		}
	}
}
