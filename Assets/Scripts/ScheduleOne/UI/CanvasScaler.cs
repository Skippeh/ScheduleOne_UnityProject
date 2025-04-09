using System;
using UnityEngine;

namespace ScheduleOne.UI
{
	[RequireComponent(typeof(CanvasScaler))]
	public class CanvasScaler : MonoBehaviour
	{
		public static float CanvasScaleFactor;

		public static Action OnCanvasScaleFactorChanged;

		public float ScaleMultiplier;

		private Vector2 referenceResolution;

		private UnityEngine.UI.CanvasScaler canvasScaler;

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
