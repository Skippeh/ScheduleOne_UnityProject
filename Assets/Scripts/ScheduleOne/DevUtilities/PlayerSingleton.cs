using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public abstract class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		private static T instance;

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

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void OnStartClient(bool IsOwner)
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
