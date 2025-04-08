namespace ScheduleOne.Management
{
	public class NumberField : global::ScheduleOne.Management.ConfigField
	{
		public global::UnityEngine.Events.UnityEvent<float> onItemChanged;

		public float Value { get; protected set; }

		public float MinValue { get; protected set; }

		public float MaxValue { get; protected set; }

		public bool WholeNumbers { get; protected set; }

		public NumberField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetValue(float value, bool network)
		{
		}

		public void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.NumberFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.NumberFieldData data)
		{
		}
	}
}
