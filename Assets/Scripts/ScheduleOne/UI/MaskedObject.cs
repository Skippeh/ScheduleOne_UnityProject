namespace ScheduleOne.UI
{
	public class MaskedObject : global::UnityEngine.EventSystems.UIBehaviour
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.CanvasRenderer canvasRendererToClip;

		public bool includeChildren;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Canvas rootCanvas;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform maskRectTransform;

		private bool initialized;

		private global::System.Collections.Generic.List<global::UnityEngine.CanvasRenderer> canvasRenderersToClip;

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Initialize(global::UnityEngine.Canvas rootCanvas, global::UnityEngine.RectTransform maskRectTransform)
		{
		}

		private void SetTargetClippingRect()
		{
		}
	}
}
