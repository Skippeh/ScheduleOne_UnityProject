namespace ScheduleOne
{
	public class UIMapPanel : global::ScheduleOne.UIPanel, global::ScheduleOne.INonNavigablePanel
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.PinchableScrollRect mapScrollRect;

		[global::UnityEngine.SerializeField]
		private float scrollSensitivity;

		[global::UnityEngine.SerializeField]
		private float minZoomScrollSpeedMult;

		[global::UnityEngine.SerializeField]
		private float maxZoomScrollSpeedMult;

		[global::UnityEngine.SerializeField]
		private float zoomSensitivity;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform centerPoint;

		private const float initialHoldThreshold = 0.5f;

		private const float repeatInterval = 0.25f;

		private float zoomTimer;

		private bool wasZoomPressedLastFrame;

		private global::System.Collections.Generic.List<global::ScheduleOne.UIMapItem> mapItems;

		private global::ScheduleOne.UIMapItem snappedItem;

		private bool lockMapInput;

		public bool LockMapInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void Navigate()
		{
		}

		private void Zoom()
		{
		}

		public void RegisterMapItem(global::ScheduleOne.UIMapItem item)
		{
		}

		public void DeregisterMapItem(global::ScheduleOne.UIMapItem item)
		{
		}

		public void SetSnappedItem(global::ScheduleOne.UIMapItem newItem)
		{
		}

		public void ResetSnappedItem()
		{
		}

		private void SnapToNearestMapItem()
		{
		}

		private void SnapMapToItem(global::ScheduleOne.UIMapItem item)
		{
		}

		protected override void HandleInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}
	}
}
