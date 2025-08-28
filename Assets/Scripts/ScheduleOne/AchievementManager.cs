namespace ScheduleOne
{
	public class AchievementManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.AchievementManager>
	{
		public enum EAchievement
		{
			COMPLETE_PROLOGUE = 0,
			RV_DESTROYED = 1,
			DEALER_RECRUITED = 2,
			MASTER_CHEF = 3,
			BUSINESSMAN = 4,
			BIGWIG = 5,
			MAGNATE = 6,
			UPSTANDING_CITIZEN = 7,
			ROLLING_IN_STYLE = 8,
			LONG_ARM_OF_THE_LAW = 9,
			INDIAN_DEALER = 10,
			URBAN_ARTIST = 11,
			FINISHING_THE_JOB = 12
		}

		private global::ScheduleOne.AchievementManager.EAchievement[] achievements;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.AchievementManager.EAchievement, bool> achievementUnlocked;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void PullAchievements()
		{
		}

		public void UnlockAchievement(global::ScheduleOne.AchievementManager.EAchievement achievement)
		{
		}
	}
}
