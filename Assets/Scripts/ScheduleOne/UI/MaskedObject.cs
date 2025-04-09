using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScheduleOne.UI
{
	public class MaskedObject : UIBehaviour
	{
		[SerializeField]
		private CanvasRenderer canvasRendererToClip;

		public bool includeChildren;

		[SerializeField]
		private Canvas rootCanvas;

		[SerializeField]
		private RectTransform maskRectTransform;

		private bool initialized;

		private List<CanvasRenderer> canvasRenderersToClip;

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
		}

		private void SetTargetClippingRect()
		{
		}
	}
}
