namespace ScheduleOne.Management.Objects
{
	public abstract class ManageableObject : global::UnityEngine.MonoBehaviour
	{
		public abstract global::ScheduleOne.Management.ManageableObjectType GetObjectType();

		public abstract global::ScheduleOne.Management.Presets.Preset GetCurrentPreset();

		public void SetPreset(global::ScheduleOne.Management.Presets.Preset newPreset)
		{
		}

		protected virtual void SetPreset_Internal(global::ScheduleOne.Management.Presets.Preset preset)
		{
		}

		public void ExistingPresetDeleted(global::ScheduleOne.Management.Presets.Preset replacement)
		{
		}
	}
}
