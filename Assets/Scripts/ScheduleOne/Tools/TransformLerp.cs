namespace ScheduleOne.Tools
{
	[global::System.Serializable]
	public class TransformLerp
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _transform;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _min;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _max;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private bool _lerpPosition;

		[global::UnityEngine.SerializeField]
		private bool _lerpRotation;

		[global::UnityEngine.SerializeField]
		private bool _lerpScale;

		[global::UnityEngine.SerializeField]
		private bool _disableOnZero;

		private float _currentLerpValue;

		public void SetLerpValue(float lerpValue)
		{
		}
	}
}
