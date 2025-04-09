namespace ScheduleOne.DevUtilities
{
	public abstract class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		protected override void Awake()
		{
		}
	}
}
