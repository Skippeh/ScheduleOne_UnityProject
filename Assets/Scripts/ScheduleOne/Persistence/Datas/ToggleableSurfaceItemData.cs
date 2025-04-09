using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	public class ToggleableSurfaceItemData : SurfaceItemData
	{
		public bool IsOn;

		public ToggleableSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, bool isOn)
			: base(default(Guid), null, 0, null, default(Vector3), default(Quaternion))
		{
		}
	}
}
