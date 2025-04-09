using UnityEngine;

namespace LiquidVolumeFX
{
	public class SpotlightAnimator : MonoBehaviour
	{
		public float lightOnDelay;

		public float targetIntensity;

		public float initialIntensity;

		public float duration;

		public float nextColorInterval;

		public float colorChangeDuration;

		private Light spotLight;

		private float lastColorChange;

		private float colorChangeStarted;

		private Color currentColor;

		private Color nextColor;

		private bool changingColor;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
