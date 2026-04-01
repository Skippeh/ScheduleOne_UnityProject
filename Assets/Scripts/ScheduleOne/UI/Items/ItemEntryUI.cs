namespace ScheduleOne.UI.Items
{
	public class ItemEntryUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _nameLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _quantityLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Image _icon;

		public void Set(string name, int quantity, global::UnityEngine.Sprite icon)
		{
		}

		public void SetLabelOnly(string name)
		{
		}
	}
}
