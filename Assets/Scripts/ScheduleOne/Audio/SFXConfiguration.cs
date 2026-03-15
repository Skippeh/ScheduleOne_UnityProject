namespace ScheduleOne.Audio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "SFXConfiguration", menuName = "ScheduleOne/Configurations/SFX Configuration")]
	public class SFXConfiguration : global::ScheduleOne.Configuration.Configuration<global::ScheduleOne.Core.Settings.SFXSettings>
	{
		public global::ScheduleOne.Audio.AudioSourceController ImpactSoundPrefab;

		public bool TryGetImpactTypeData(global::ScheduleOne.Core.Audio.EImpactSound material, out global::ScheduleOne.Core.Settings.SFXSettings.ImpactSound data)
		{
			data = null;
			return false;
		}

		public bool TryGetFootstepSoundGroup(global::ScheduleOne.Core.EMaterialType materialType, out global::ScheduleOne.Core.Settings.SFXSettings.FootstepSound group)
		{
			group = null;
			return false;
		}
	}
}
