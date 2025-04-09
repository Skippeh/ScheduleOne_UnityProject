using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class CauldronCanvas : Singleton<CauldronCanvas>
	{
		[Header("References")]
		public Canvas Canvas;

		public GameObject Container;

		public List<ItemSlotUI> IngredientSlotUIs;

		public ItemSlotUI LiquidSlotUI;

		public ItemSlotUI OutputSlotUI;

		public TextMeshProUGUI InstructionLabel;

		public Button BeginButton;

		public bool isOpen { get; protected set; }

		public Cauldron Cauldron { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)
		{
		}

		public void BeginButtonPressed()
		{
		}
	}
}
