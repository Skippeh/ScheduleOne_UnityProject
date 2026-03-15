namespace ScheduleOne
{
	public abstract class UIPopupScreen : global::ScheduleOne.UIScreen
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Identifier of the PopupScreen when you called OpenPopupScreen from UIScreenManager")]
		private string popupID;

		public string PopupID => null;

		public virtual void Open(params object[] args)
		{
		}

		public virtual void Close()
		{
		}
	}
}
