using System.Collections.Generic;

namespace ScheduleOne.Management.Presets.Options
{
	public class ItemList : Option
	{
		public bool All;

		public bool None;

		public List<string> Selection;

		public bool CanBeAll { get; protected set; }

		public bool CanBeNone { get; protected set; }

		public List<string> OptionList { get; protected set; }

		public ItemList(string name, List<string> optionList, bool canBeAll, bool canBeNone)
			: base(null)
		{
		}

		public override void CopyTo(Option other)
		{
		}

		public override string GetDisplayString()
		{
			return null;
		}
	}
}
