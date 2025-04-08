namespace ScheduleOne.Management.Presets.Options
{
	public class ItemList : global::ScheduleOne.Management.Presets.Options.Option
	{
		public bool All;

		public bool None;

		public global::System.Collections.Generic.List<string> Selection;

		public bool CanBeAll { get; protected set; }

		public bool CanBeNone { get; protected set; }

		public global::System.Collections.Generic.List<string> OptionList { get; protected set; }

		public ItemList(string name, global::System.Collections.Generic.List<string> optionList, bool canBeAll, bool canBeNone)
			: base(null)
		{
		}

		public override void CopyTo(global::ScheduleOne.Management.Presets.Options.Option other)
		{
		}

		public override string GetDisplayString()
		{
			return null;
		}
	}
}
