namespace ScheduleOne.Management.Presets
{
	public class PotPreset : global::ScheduleOne.Management.Presets.Preset
	{
		public global::ScheduleOne.Management.Presets.Options.ItemList Seeds;

		public global::ScheduleOne.Management.Presets.Options.ItemList Additives;

		protected static global::ScheduleOne.Management.Presets.PotPreset DefaultPreset { get; set; }

		public override global::ScheduleOne.Management.Presets.Preset GetCopy()
		{
			return null;
		}

		public override void CopyTo(global::ScheduleOne.Management.Presets.Preset other)
		{
		}

		public override void InitializeOptions()
		{
		}

		public static global::ScheduleOne.Management.Presets.PotPreset GetDefaultPreset()
		{
			return null;
		}

		public static global::ScheduleOne.Management.Presets.PotPreset GetNewBlankPreset()
		{
			return null;
		}
	}
}
