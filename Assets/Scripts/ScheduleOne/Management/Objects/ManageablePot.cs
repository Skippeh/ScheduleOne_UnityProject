namespace ScheduleOne.Management.Objects
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.ObjectScripts.Pot))]
	public class ManageablePot : global::ScheduleOne.Management.Objects.ManageableObject
	{
		public global::ScheduleOne.Management.Presets.PotPreset CurrentPreset;

		protected virtual void Awake()
		{
		}

		public override global::ScheduleOne.Management.ManageableObjectType GetObjectType()
		{
			return default(global::ScheduleOne.Management.ManageableObjectType);
		}

		public override global::ScheduleOne.Management.Presets.Preset GetCurrentPreset()
		{
			return null;
		}

		protected override void SetPreset_Internal(global::ScheduleOne.Management.Presets.Preset newPreset)
		{
		}
	}
}
