using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class NumberField : ConfigField
	{
		public UnityEvent<float> onItemChanged;

		public float Value { get; protected set; }

		public float MinValue { get; protected set; }

		public float MaxValue { get; protected set; }

		public bool WholeNumbers { get; protected set; }

		public NumberField(EntityConfiguration parentConfig)
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

		public NumberFieldData GetData()
		{
			return null;
		}

		public void Load(NumberFieldData data)
		{
		}
	}
}
