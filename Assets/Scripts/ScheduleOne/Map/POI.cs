namespace ScheduleOne.Map
{
	public class POI : global::UnityEngine.MonoBehaviour
	{
		public enum TextShowMode
		{
			Off = 0,
			Always = 1,
			OnHover = 2
		}

		public global::ScheduleOne.Map.POI.TextShowMode MainTextVisibility;

		public string DefaultMainText;

		public bool AutoUpdatePosition;

		public bool Rotate;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject UIPrefab;

		protected global::UnityEngine.UI.Text mainLabel;

		protected global::UnityEngine.UI.Button button;

		protected global::UnityEngine.EventSystems.EventTrigger eventTrigger;

		private bool mainTextSet;

		public global::UnityEngine.Events.UnityEvent onUICreated;

		public bool UISetup { get; protected set; }

		public string MainText { get; protected set; }

		public global::UnityEngine.RectTransform UI { get; protected set; }

		public global::UnityEngine.RectTransform IconContainer { get; protected set; }

		public global::ScheduleOne.DevUtilities.FontSetter FontSetter { get; protected set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void SetMainText(string text)
		{
		}

		public virtual void UpdatePosition()
		{
		}

		public virtual void InitializeUI()
		{
		}

		protected virtual void HoverStart()
		{
		}

		protected virtual void HoverEnd()
		{
		}

		protected virtual void Clicked()
		{
		}
	}
}
