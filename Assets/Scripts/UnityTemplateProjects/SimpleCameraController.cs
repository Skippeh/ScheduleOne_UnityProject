namespace UnityTemplateProjects
{
	public class SimpleCameraController : global::UnityEngine.MonoBehaviour
	{
		private class CameraState
		{
			public float yaw;

			public float pitch;

			public float roll;

			public float x;

			public float y;

			public float z;

			public void SetFromTransform(global::UnityEngine.Transform t)
			{
			}

			public void Translate(global::UnityEngine.Vector3 translation)
			{
			}

			public void LerpTowards(global::UnityTemplateProjects.SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			public void UpdateTransform(global::UnityEngine.Transform t)
			{
			}
		}

		private global::UnityTemplateProjects.SimpleCameraController.CameraState m_TargetCameraState;

		private global::UnityTemplateProjects.SimpleCameraController.CameraState m_InterpolatingCameraState;

		[global::UnityEngine.Header("Movement Settings")]
		[global::UnityEngine.Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[global::UnityEngine.Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[global::UnityEngine.Range(0.001f, 1f)]
		public float positionLerpTime;

		[global::UnityEngine.Header("Rotation Settings")]
		[global::UnityEngine.Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public global::UnityEngine.AnimationCurve mouseSensitivityCurve;

		[global::UnityEngine.Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[global::UnityEngine.Range(0.001f, 1f)]
		public float rotationLerpTime;

		[global::UnityEngine.Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		private void OnEnable()
		{
		}

		private global::UnityEngine.Vector3 GetInputTranslationDirection()
		{
			return default(global::UnityEngine.Vector3);
		}

		private void Update()
		{
		}
	}
}
