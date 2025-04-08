namespace ScheduleOne.UI
{
	public class OffenceNoticeUI : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.OffenceNoticeUI>
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject container;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.UI.Text> charges;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.UI.Text> penalties;

		public void ShowOffenceNotice(global::ScheduleOne.Police.Offense offence)
		{
		}

		protected void Update()
		{
		}
	}
}
