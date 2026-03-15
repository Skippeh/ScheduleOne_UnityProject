namespace ScheduleOne.Audio
{
	public class PursuitMusicTrack : global::ScheduleOne.Audio.MusicTrack
	{
		private const float OutOfSightTimeToDipMusic = 8f;

		private const float MinMusicVolume = 0.6f;

		private const float MusicChangeRate_Down = 0.04f;

		private const float MusicChangeRate_Up = 2f;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel _pursuitLevelToActivate;

		protected virtual void Start()
		{
		}

		private void OnLoadComplete()
		{
		}

		private void RegisterEvent()
		{
		}

		protected override void Update()
		{
		}

		private void PursuitLevelChange(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel oldLevel, global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel newLevel)
		{
		}

		private float GetNewVolume()
		{
			return 0f;
		}
	}
}
