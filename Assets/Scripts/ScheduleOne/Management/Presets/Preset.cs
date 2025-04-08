namespace ScheduleOne.Management.Presets
{
	public abstract class Preset
	{
		public delegate void NameChange(string name);

		public delegate void PresetDeletion(global::ScheduleOne.Management.Presets.Preset replacement);

		public string PresetName;

		public global::UnityEngine.Color32 PresetColor;

		public global::ScheduleOne.Management.ManageableObjectType ObjectType;

		public global::ScheduleOne.Management.Presets.Preset.NameChange onNameChanged;

		public global::ScheduleOne.Management.Presets.Preset.PresetDeletion onDeleted;

		public Preset()
		{
		}

		public abstract global::ScheduleOne.Management.Presets.Preset GetCopy();

		public virtual void CopyTo(global::ScheduleOne.Management.Presets.Preset other)
		{
		}

		public abstract void InitializeOptions();

		public void SetName(string newName)
		{
		}

		public void DeletePreset(global::ScheduleOne.Management.Presets.Preset replacement)
		{
		}

		public static global::ScheduleOne.Management.Presets.Preset GetDefault(global::ScheduleOne.Management.ManageableObjectType type)
		{
			return null;
		}
	}
}
