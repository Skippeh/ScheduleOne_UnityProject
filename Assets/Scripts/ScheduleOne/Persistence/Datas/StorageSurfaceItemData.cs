using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	public class StorageSurfaceItemData : SurfaceItemData
	{
		public ItemSet Contents;

		public StorageSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, ItemSet contents)
			: base(default(Guid), null, 0, null, default(Vector3), default(Quaternion))
		{
		}
	}
}
