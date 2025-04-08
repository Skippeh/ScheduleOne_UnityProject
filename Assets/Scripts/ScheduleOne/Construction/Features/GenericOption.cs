namespace ScheduleOne.Construction.Features
{
	public class GenericOption : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Interface settings")]
		public string optionName;

		public global::UnityEngine.Color optionButtonColor;

		public float optionPrice;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onInstalled;

		public global::UnityEngine.Events.UnityEvent onUninstalled;

		public global::UnityEngine.Events.UnityEvent onSetVisible;

		public global::UnityEngine.Events.UnityEvent onSetInvisible;

		public virtual void Install()
		{
		}

		public virtual void Uninstall()
		{
		}

		public virtual void SetVisible()
		{
		}

		public virtual void SetInvisible()
		{
		}
	}
}
