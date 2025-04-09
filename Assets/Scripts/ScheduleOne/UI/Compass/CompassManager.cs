using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Compass
{
	public class CompassManager : Singleton<CompassManager>
	{
		public class Notch
		{
			public RectTransform Rect;

			public CanvasGroup Group;
		}

		public class Element
		{
			public bool Visible;

			public RectTransform Rect;

			public CanvasGroup Group;

			public TextMeshProUGUI DistanceLabel;

			public Transform Transform;
		}

		public const float DISTANCE_LABEL_THRESHOLD = 50f;

		[Header("References")]
		public RectTransform Container;

		public Transform NotchPointContainer;

		public RectTransform NotchUIContainer;

		public RectTransform ElementUIContainer;

		public Canvas Canvas;

		[Header("Prefabs")]
		public GameObject DirectionIndicatorPrefab;

		public GameObject NotchPrefab;

		public GameObject ElementPrefab;

		[Header("Settings")]
		public bool CompassEnabled;

		public Vector2 ElementContentSize;

		public float CompassUIRange;

		public float FullAlphaRange;

		public float AngleDivisor;

		public float ClosedYPos;

		public float OpenYPos;

		private List<Transform> notchPositions;

		private List<Notch> notches;

		private List<Element> elements;

		private Coroutine lerpContainerPositionCoroutine;

		private Transform cam => null;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
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

		private void UpdateElement(Element element)
		{
		}

		public void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			xPos = default(float);
			alpha = default(float);
		}

		public Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			return null;
		}

		public void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
		}

		public void RemoveElement(Element el, bool alsoDestroyRect = true)
		{
		}
	}
}
