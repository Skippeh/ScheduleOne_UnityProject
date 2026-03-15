namespace ScheduleOne.Map.Infrastructure
{
	public class TrafficLight : global::UnityEngine.MonoBehaviour
	{
		public enum State
		{
			Red = 0,
			Orange = 1,
			Green = 2
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Misc.ToggleableLight _redLight;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Misc.ToggleableLight _orangeLight;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Misc.ToggleableLight _greenLight;

		private global::ScheduleOne.Map.Infrastructure.TrafficLight.State _state;

		public global::ScheduleOne.Map.Infrastructure.TrafficLight.State CurrentState
		{
			get
			{
				return default(global::ScheduleOne.Map.Infrastructure.TrafficLight.State);
			}
			set
			{
			}
		}

		protected virtual void ApplyState()
		{
		}
	}
}
