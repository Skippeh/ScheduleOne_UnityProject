namespace ScheduleOne.DevUtilities
{
	public abstract class Singleton<T> : global::UnityEngine.MonoBehaviour where T : global::ScheduleOne.DevUtilities.Singleton<T>
	{
		private static T instance;

		protected bool Destroyed;

		public static bool InstanceExists => false;

		public static T Instance
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
