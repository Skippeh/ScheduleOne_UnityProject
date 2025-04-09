using ScheduleOne.Management.Presets;
using UnityEngine;

namespace ScheduleOne.Management.Objects
{
	public abstract class ManageableObject : MonoBehaviour
	{
		public abstract ManageableObjectType GetObjectType();

		public abstract Preset GetCurrentPreset();

		public void SetPreset(Preset newPreset)
		{
		}

		protected virtual void SetPreset_Internal(Preset preset)
		{
		}

		public void ExistingPresetDeleted(Preset replacement)
		{
		}
	}
}
