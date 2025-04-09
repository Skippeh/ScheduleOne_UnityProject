using UnityEngine;

namespace ScheduleOne.Management.Presets
{
	public abstract class Preset
	{
		public delegate void NameChange(string name);

		public delegate void PresetDeletion(Preset replacement);

		public string PresetName;

		public Color32 PresetColor;

		public ManageableObjectType ObjectType;

		public NameChange onNameChanged;

		public PresetDeletion onDeleted;

		public Preset()
		{
		}

		public abstract Preset GetCopy();

		public virtual void CopyTo(Preset other)
		{
		}

		public abstract void InitializeOptions();

		public void SetName(string newName)
		{
		}

		public void DeletePreset(Preset replacement)
		{
		}

		public static Preset GetDefault(ManageableObjectType type)
		{
			return null;
		}
	}
}
