using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Map
{
	public class POI : MonoBehaviour
	{
		public enum TextShowMode
		{
			Off = 0,
			Always = 1,
			OnHover = 2
		}

		public TextShowMode MainTextVisibility;

		public string DefaultMainText;

		public bool AutoUpdatePosition;

		public bool Rotate;

		[SerializeField]
		protected GameObject UIPrefab;

		protected Text mainLabel;

		protected Button button;

		protected EventTrigger eventTrigger;

		private bool mainTextSet;

		public UnityEvent onUICreated;

		public bool UISetup { get; protected set; }

		public string MainText { get; protected set; }

		public RectTransform UI { get; protected set; }

		public RectTransform IconContainer { get; protected set; }

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
