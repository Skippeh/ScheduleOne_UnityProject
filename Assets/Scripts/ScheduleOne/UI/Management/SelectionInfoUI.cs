namespace ScheduleOne.UI.Management
{
	public class SelectionInfoUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image Icon;

		public global::TMPro.TextMeshProUGUI Title;

		[global::UnityEngine.Header("Settings")]
		public bool SelfUpdate;

		public global::UnityEngine.Sprite NonUniformTypeSprite;

		public global::UnityEngine.Sprite CrossSprite;

		private void Update()
		{
		}

		public void Set(global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> Configurables)
		{
		}
	}
}
