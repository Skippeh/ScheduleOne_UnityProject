namespace ScheduleOne.Management
{
	public class QualityField : global::ScheduleOne.Management.ConfigField
	{
		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.ItemFramework.EQuality> onValueChanged;

		public global::ScheduleOne.ItemFramework.EQuality Value { get; protected set; }

		public QualityField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetValue(global::ScheduleOne.ItemFramework.EQuality value, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.QualityFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.QualityFieldData data)
		{
		}
	}
}
