namespace ScheduleOne.UI
{
	public class PropertySelector : global::UnityEngine.MonoBehaviour
	{
		public delegate void PropertySelected(global::ScheduleOne.Property.Property p);

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject container;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform buttonContainer;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject buttonPrefab;

		private global::ScheduleOne.UI.PropertySelector.PropertySelected pCallback;

		public bool isOpen => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public void OpenSelector(global::ScheduleOne.UI.PropertySelector.PropertySelected p)
		{
		}

		private void PropertyAcquired(global::ScheduleOne.Property.Property p)
		{
		}

		private void SelectProperty(global::ScheduleOne.Property.Property p)
		{
		}

		private void Close(bool reenableShit)
		{
		}
	}
}
