namespace ScheduleOne.UI
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.RectTransform))]
	public class RectTransformLerp : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		protected float _defaultLerpDuration;

		[global::UnityEngine.SerializeField]
		private bool _lerpPosition;

		protected global::UnityEngine.RectTransform _rectTransform;

		private global::UnityEngine.Coroutine _positionRoutine;

		private global::UnityEngine.Coroutine _scaleRoutine;

		protected virtual void Awake()
		{
		}

		public void LerpLocalPosition(global::UnityEngine.Vector3 endLocalPosition, float duration = -1f)
		{
		}

		public void LerpLocalScale(global::UnityEngine.Vector3 endLocalscale, float duration = -1f)
		{
		}
	}
}
