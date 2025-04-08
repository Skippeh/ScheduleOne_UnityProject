namespace ScheduleOne.Growing
{
	public class PourableAdditive : global::ScheduleOne.PlayerTasks.Pourable
	{
		public const float NormalizedAmountForSuccess = 0.8f;

		public global::ScheduleOne.ItemFramework.AdditiveDefinition AdditiveDefinition;

		public global::UnityEngine.Color LiquidColor;

		private float pouredAmount;

		protected override void PourAmount(float amount)
		{
		}
	}
}
