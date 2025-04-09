using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	public abstract class ACSelection<T> : MonoBehaviour where T : Object
	{
		[Header("References")]
		public GameObject ButtonPrefab;

		[Header("Settings")]
		public int PropertyIndex;

		public List<T> Options;

		public bool Nullable;

		public int DefaultOptionIndex;

		protected List<GameObject> buttons;

		protected int SelectedOptionIndex;

		public UnityEvent<T> onValueChange;

		public UnityEvent<T, int> onValueChangeWithIndex;

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
