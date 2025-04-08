namespace ScheduleOne.AvatarFramework.Customization
{
	public abstract class ACSelection<T> : global::UnityEngine.MonoBehaviour where T : global::UnityEngine.Object
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject ButtonPrefab;

		[global::UnityEngine.Header("Settings")]
		public int PropertyIndex;

		public global::System.Collections.Generic.List<T> Options;

		public bool Nullable;

		public int DefaultOptionIndex;

		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> buttons;

		protected int SelectedOptionIndex;

		public global::UnityEngine.Events.UnityEvent<T> onValueChange;

		public global::UnityEngine.Events.UnityEvent<T, int> onValueChangeWithIndex;

		protected virtual void Awake()
		{
		}

		public void SelectOption(int index, bool notify = true)
		{
		}

		public abstract void CallValueChange();

		public abstract string GetOptionLabel(int index);

		public abstract int GetAssetPathIndex(string path);

		private void SetButtonHighlighted(int buttonIndex, bool h)
		{
		}
	}
}
