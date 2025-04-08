namespace ScheduleOne.UI
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.EventSystems.EventTrigger))]
	public class ButtonScaler : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.RectTransform ScaleTarget;

		public float HoverScale;

		public float ScaleTime;

		private global::UnityEngine.Coroutine scaleCoroutine;

		private global::UnityEngine.UI.Button button;

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
