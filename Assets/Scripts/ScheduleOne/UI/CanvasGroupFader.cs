namespace ScheduleOne.UI
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.CanvasGroup))]
	public class CanvasGroupFader : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		private float _defaultFadeDuration;

		[global::UnityEngine.SerializeField]
		private bool _scaleDurationWithFadeAmount;

		private global::UnityEngine.CanvasGroup _canvasGroup;

		private global::UnityEngine.Coroutine _fadeRoutine;

		private void Awake()
		{
		}

		public void FadeTo(float targetAlpha)
		{
		}

		public void FadeTo(float targetAlpha, float duration)
		{
		}
	}
}
