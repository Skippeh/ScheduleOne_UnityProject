using ScheduleOne.Management.Presets.Options;

namespace ScheduleOne.Management.Presets
{
	public class PotPreset : Preset
	{
		public ItemList Seeds;

		public ItemList Additives;

		protected static PotPreset DefaultPreset { get; set; }

		public override Preset GetCopy()
		{
			return null;
		}

		public override void CopyTo(Preset other)
		{
		}

		public override void InitializeOptions()
		{
		}

		public static PotPreset GetDefaultPreset()
		{
			return null;
		}

		public static PotPreset GetNewBlankPreset()
		{
			return null;
		}
	}
}
