using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	public class StoredItem_Cash : StoredItem
	{
		protected CashInstance cashInstance;

		[Header("References")]
		public CashStackVisuals Visuals;

		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		private void RefreshShownBills()
		{
		}
	}
}
