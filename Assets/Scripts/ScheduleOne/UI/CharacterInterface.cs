using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class CharacterInterface : MonoBehaviour
	{
		public ClothingSlotUI[] ClothingSlots;

		public RectTransform Container;

		public Slider RotationSlider;

		private Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints;

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
