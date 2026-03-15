namespace ScheduleOne
{
	public class UIInputDetectBehaviour : global::UnityEngine.MonoBehaviour
	{
		private float initialHoldThreshold;

		private float repeatInterval;

		private float timer;

		private bool wasPressedLastFrame;

		private global::System.Action<float> onAction;

		public void Initialize(global::System.Action<float> action, float holdThreshold, float repeat)
		{
		}

		public void ResetData()
		{
		}

		public void DoUpdate(float value)
		{
		}
	}
}
