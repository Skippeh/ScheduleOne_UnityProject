namespace ScheduleOne.Growing
{
	public class GrowContainerCameraHandler : global::UnityEngine.MonoBehaviour
	{
		public enum ECameraPosition
		{
			Closeup = 0,
			Midshot = 1,
			Fullshot = 2,
			BirdsEye = 3
		}

		[global::UnityEngine.SerializeField]
		private bool RotateCameraContainerToFacePlayer;

		[global::UnityEngine.SerializeField]
		private bool SnapRotationToRightAngles;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _midshotCamera;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _closeupCamera;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _fullshotContainer;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _birdsEyeCamera;

		[global::UnityEngine.Header("Debug & Development")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition _debugCameraPosition;

		public void PositionCameraContainer()
		{
		}

		public global::UnityEngine.Transform GetCameraPosition(global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition pos, bool autoPosition = true)
		{
			return null;
		}

		[global::EasyButtons.Button("Set Camera Position")]
		private void SetCameraPosition()
		{
		}
	}
}
