namespace ScheduleOne.ObjectScripts.Cash
{
	public class Equippable_Cash : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		private int amountIndex;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Container_Under100;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> SingleNotes;

		public global::UnityEngine.Transform Container_100_300;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> Under300Stacks;

		public global::UnityEngine.Transform Container_300Plus;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> PlusStacks;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
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
