namespace ScheduleOne.UI
{
	public class TabItemUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ButtonUI _button;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _label;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _content;

		[global::UnityEngine.Header("Additionals")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _indicator;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _indicatorLabel;

		public global::ScheduleOne.UI.ButtonUI Button => null;

		public global::UnityEngine.UI.Text Label => null;

		public global::UnityEngine.GameObject Content => null;

		public void SetIndicator(string text)
		{
		}

		public void HideIndicator()
		{
		}
	}
}
