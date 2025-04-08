namespace ScheduleOne.DevUtilities
{
	public abstract class PersistentSingleton<T> : global::ScheduleOne.DevUtilities.Singleton<T> where T : global::ScheduleOne.DevUtilities.Singleton<T>
	{
		protected override void Awake()
		{
		}
	}
}
