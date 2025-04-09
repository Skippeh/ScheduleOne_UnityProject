using System.Collections.Generic;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	public class Equippable_Cash : Equippable_Viewmodel
	{
		private int amountIndex;

		[Header("References")]
		public Transform Container_Under100;

		public List<Transform> SingleNotes;

		public Transform Container_100_300;

		public List<Transform> Under300Stacks;

		public Transform Container_300Plus;

		public List<Transform> PlusStacks;

		protected override void Update()
		{
		}

		protected override void StartBuildingStoredItem()
		{
		}

		protected override void StopBuildingStoredItem()
		{
		}

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		private void UpdateCashVisuals()
		{
		}
	}
}
