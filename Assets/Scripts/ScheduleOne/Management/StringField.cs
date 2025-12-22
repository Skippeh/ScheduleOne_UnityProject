namespace ScheduleOne.Management
{
	public class StringField : global::ScheduleOne.Management.ConfigField
	{
		private string _defaultValue;

		private bool _canBeNullOrEmpty;

		public global::UnityEngine.Events.UnityEvent<string> onItemChanged;

		public string Value { get; protected set; }

		public int CharacterLimit { get; protected set; }

		public StringField(global::ScheduleOne.Management.EntityConfiguration parentConfig, string defaultValue)
			: base(null)
		{
		}

		public void SetValue(string value, bool network)
		{
		}

		public void Configure(int characterLimit, bool canBeNullOrEmpty)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.StringFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.StringFieldData data)
		{
		}
	}
}
