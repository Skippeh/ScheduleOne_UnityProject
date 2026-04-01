namespace ScheduleOne.UI
{
	public class ReticleUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ReticleLineUI[] _lineUI;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.CanvasGroup _canvas;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float _lineLength;

		[global::UnityEngine.SerializeField]
		private float _lineThickness;

		[global::UnityEngine.SerializeField]
		private float _borderThickness;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _lineColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _borderColor;

		[global::UnityEngine.SerializeField]
		private float _minGap;

		[global::UnityEngine.SerializeField]
		private float _lerpSpeed;

		private float _radius;

		private float _currentRadius;

		private float _lastSpreadAngle;

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void Set(float spreadAngle)
		{
		}

		private void Update()
		{
		}

		private void ApplyLineSizes()
		{
		}

		private void ApplyColors()
		{
		}
	}
}
