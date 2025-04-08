namespace LiquidVolumeFX
{
	public class SpotlightAnimator : global::UnityEngine.MonoBehaviour
	{
		public float lightOnDelay;

		public float targetIntensity;

		public float initialIntensity;

		public float duration;

		public float nextColorInterval;

		public float colorChangeDuration;

		private global::UnityEngine.Light spotLight;

		private float lastColorChange;

		private float colorChangeStarted;

		private global::UnityEngine.Color currentColor;

		private global::UnityEngine.Color nextColor;

		private bool changingColor;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
