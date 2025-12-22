namespace ScheduleOne.Temperature
{
	public class TemperatureEmitter : global::UnityEngine.MonoBehaviour
	{
		public const int DefaultAmbientTemperature = 20;

		public const int MinTemperature = 0;

		public const int MaxTemperature = 40;

		public global::System.Action OnEmitterChanged;

		[field: global::UnityEngine.SerializeField]
		public float Temperature { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float Range { get; private set; }

		public global::UnityEngine.Vector3 EmissionPoint => default(global::UnityEngine.Vector3);

		public void SetPosition(global::UnityEngine.Vector3 position)
		{
		}

		public void SetTemperature(float temperature)
		{
		}

		public void SetRange(float range)
		{
		}

		public void NotifyChanged()
		{
		}
	}
}
