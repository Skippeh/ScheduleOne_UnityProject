namespace ScheduleOne.UI.Settings
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	public class PlayerLogExporterButton : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		private bool _exportPreviousLog;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Events.UnityEvent OnSuccess;

		private global::UnityEngine.UI.Button _button;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnButtonClick()
		{
		}

		private void Success()
		{
		}

		private bool DoesLogExist()
		{
			return false;
		}
	}
}
