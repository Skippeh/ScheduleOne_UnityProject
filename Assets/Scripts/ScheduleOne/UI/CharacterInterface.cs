namespace ScheduleOne.UI
{
	public class CharacterInterface : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.UI.ClothingSlotUI[] ClothingSlots;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.Slider RotationSlider;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.UI.ClothingSlotUI, global::UnityEngine.Transform> SlotAlignmentPoints;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
