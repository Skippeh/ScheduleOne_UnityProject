namespace ScheduleOne.PlayerScripts
{
	public class PlayerEnergy : global::UnityEngine.MonoBehaviour
	{
		public const float CRITICAL_THRESHOLD = 20f;

		public const float MAX_ENERGY = 100f;

		public const float SPRINT_DRAIN_MULTIPLIER = 1.3f;

		public bool DEBUG_DISABLE_ENERGY;

		[global::UnityEngine.Header("Settings")]
		public float EnergyDuration_Hours;

		public float EnergyRechargeTime_Hours;

		public global::UnityEngine.Events.UnityEvent onEnergyChanged;

		public global::UnityEngine.Events.UnityEvent onEnergyDepleted;

		public float CurrentEnergy { get; protected set; }

		public int EnergyDrinksConsumed { get; protected set; }

		protected virtual void Start()
		{
		}

		private void MinPass()
		{
		}

		private void ChangeEnergy(float change)
		{
		}

		public void SetEnergy(float newEnergy)
		{
		}

		public void RestoreEnergy()
		{
		}

		private void SleepEnd()
		{
		}

		public void IncrementEnergyDrinks()
		{
		}

		private void ResetEnergyDrinks()
		{
		}
	}
}
