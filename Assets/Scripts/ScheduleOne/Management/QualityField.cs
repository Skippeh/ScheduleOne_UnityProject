using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class QualityField : ConfigField
	{
		public UnityEvent<EQuality> onValueChanged;

		public EQuality Value { get; protected set; }

		public QualityField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetValue(EQuality value, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public QualityFieldData GetData()
		{
			return null;
		}

		public void Load(QualityFieldData data)
		{
		}
	}
}
