using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		public const float MAX_SPEED_BOOST = 2.5f;

		public Color SlotRedColor;

		public Color SlotHighlightRedColor;

		public float GapTime;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public RectTransform MinigameController;

		public RectTransform SlotContainer;

		public ItemSlotUI ItemSlotPrefab;

		public RectTransform SearchIndicator;

		public RectTransform SearchIndicatorStart;

		public RectTransform SearchIndicatorEnd;

		public Animation IndicatorAnimation;

		public Animation TutorialAnimation;

		public RectTransform TutorialContainer;

		public Animation ResetAnimation;

		private List<ItemSlotUI> slots;

		public UnityEvent onSearchClear;

		public UnityEvent onSearchFail;

		private Color defaultSlotColor;

		private Color defaultSlotHighlightColor;

		private ItemSlotUI concealedSlot;

		private ItemSlotUI hoveredSlot;

		private Color[] defaultItemIconColors;

		private float speedBoost;

		private NPC searcher;

		public bool IsOpen { get; private set; }

		public bool TutorialOpen { get; private set; }

		protected override void Start()
		{
		}

		private void SetupSlots()
		{
		}

		private void Update()
		{
		}

		public void Open(NPC _searcher, float searchTime = 0f)
		{
		}

		private bool IsSlotConcealed(ItemSlotUI slot)
		{
			return false;
		}

		private void ItemDetected(ItemSlotUI slot)
		{
		}

		public void SlotHeld(ItemSlotUI ui)
		{
		}

		public void SlotReleased(ItemSlotUI ui)
		{
		}

		public void Close(bool clear)
		{
		}

		private void OpenTutorial()
		{
		}

		public void CloseTutorial()
		{
		}
	}
}
