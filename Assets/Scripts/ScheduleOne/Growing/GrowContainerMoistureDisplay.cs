namespace ScheduleOne.Growing
{
	public class GrowContainerMoistureDisplay : global::UnityEngine.MonoBehaviour
	{
		public const float MaxCameraDistance = 2.5f;

		public const float MinCameraDistance = 0.5f;

		public const float FadeInDistance = 0.7f;

		public const float FadeOutDistance = 0.25f;

		public bool SnapToRightAngles;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Growing.GrowContainer GrowContainer;

		public global::UnityEngine.Transform WaterCanvasContainer;

		public global::UnityEngine.Canvas WaterLevelCanvas;

		public global::UnityEngine.CanvasGroup WaterLevelCanvasGroup;

		public global::UnityEngine.UI.Slider WaterLevelSlider;

		public global::UnityEngine.GameObject NoWaterIcon;

		protected virtual void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateCanvas()
		{
		}

		protected virtual void UpdateCanvasContents()
		{
		}
	}
}
