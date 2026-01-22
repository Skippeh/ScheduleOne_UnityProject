namespace ScheduleOne.Storage
{
	public class StorageDoorAnimation : global::UnityEngine.MonoBehaviour
	{
		private bool overriddeIsOpen;

		private bool overrideState;

		[global::UnityEngine.SerializeField]
		private bool _disableItemContainerWhenClosed;

		[global::UnityEngine.Header("Animations")]
		public global::UnityEngine.Animation[] Anims;

		public global::UnityEngine.AnimationClip OpenAnim;

		public global::UnityEngine.AnimationClip CloseAnim;

		public global::ScheduleOne.Audio.AudioSourceController OpenSound;

		public global::ScheduleOne.Audio.AudioSourceController CloseSound;

		private global::ScheduleOne.Storage.StorageEntity storageEntity;

		private global::UnityEngine.Transform itemContainer;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		[global::EasyButtons.Button]
		public void Open()
		{
		}

		[global::EasyButtons.Button]
		public void Close()
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		protected virtual void RefreshItemsVisible()
		{
		}

		public void OverrideState(bool open)
		{
		}

		public void ResetOverride()
		{
		}
	}
}
