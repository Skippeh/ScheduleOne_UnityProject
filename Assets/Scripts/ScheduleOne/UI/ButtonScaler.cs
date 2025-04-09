using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	public class ButtonScaler : MonoBehaviour
	{
		public RectTransform ScaleTarget;

		public float HoverScale;

		public float ScaleTime;

		private Coroutine scaleCoroutine;

		private Button button;

		private void Awake()
		{
		}

		private void Hovered()
		{
		}

		private void HoverEnd()
		{
		}

		private void SetScale(float endScale)
		{
		}
	}
}
