namespace ScheduleOne.UI.Compass
{
	public class CompassManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Compass.CompassManager>
	{
		public class Notch
		{
			public global::UnityEngine.RectTransform Rect;

			public global::UnityEngine.CanvasGroup Group;
		}

		public class Element
		{
			public bool LastState;

			public bool Visible;

			public global::UnityEngine.RectTransform Rect;

			public global::UnityEngine.CanvasGroup Group;

			public global::TMPro.TextMeshProUGUI DistanceLabel;

			public global::UnityEngine.Transform Transform;
		}

		public const int NOTCH_COUNT = 24;

		public const float DISTANCE_LABEL_THRESHOLD = 50f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform NotchUIContainer;

		public global::UnityEngine.RectTransform ElementUIContainer;

		public global::UnityEngine.Canvas Canvas;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject DirectionIndicatorPrefab;

		public global::UnityEngine.GameObject NotchPrefab;

		public global::UnityEngine.GameObject ElementPrefab;

		[global::UnityEngine.Header("Settings")]
		public bool CompassEnabled;

		public global::UnityEngine.Vector2 ElementContentSize;

		public float CompassUIRange;

		public float FullAlphaRange;

		public float AngleDivisor;

		public float ClosedYPos;

		public float OpenYPos;

		private global::System.Collections.Generic.List<global::UnityEngine.Vector3> notchPositions;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Compass.CompassManager.Notch> notches;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Compass.CompassManager.Element> elements;

		private global::UnityEngine.Coroutine lerpContainerPositionCoroutine;

		private global::UnityEngine.Transform cam => null;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void Update()
		{
		}

		public void SetCompassEnabled(bool enabled)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		private void UpdateNotches()
		{
		}

		private void UpdateElements()
		{
		}

		private void UpdateElement(global::ScheduleOne.UI.Compass.CompassManager.Element element)
		{
		}

		public void GetCompassData(global::UnityEngine.Vector3 worldPosition, out float xPos, out float alpha)
		{
			xPos = default(float);
			alpha = default(float);
		}

		public global::ScheduleOne.UI.Compass.CompassManager.Element AddElement(global::UnityEngine.Transform transform, global::UnityEngine.RectTransform contentPrefab, bool visible = true)
		{
			return null;
		}

		public void RemoveElement(global::UnityEngine.Transform transform, bool alsoDestroyRect = true)
		{
		}

		public void RemoveElement(global::ScheduleOne.UI.Compass.CompassManager.Element el, bool alsoDestroyRect = true)
		{
		}
	}
}
