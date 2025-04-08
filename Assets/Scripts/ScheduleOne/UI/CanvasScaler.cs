namespace ScheduleOne.UI
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.UI.CanvasScaler))]
	public class CanvasScaler : global::UnityEngine.MonoBehaviour
	{
		public static float CanvasScaleFactor;

		public static global::System.Action OnCanvasScaleFactorChanged;

		public float ScaleMultiplier;

		private global::UnityEngine.Vector2 referenceResolution;

		private global::UnityEngine.UI.CanvasScaler canvasScaler;

		public static float NormalizedCanvasScaleFactor => 0f;

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void RefreshScale()
		{
		}

		public static void SetScaleFactor(float scaleFactor)
		{
		}
	}
}
