using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		public string ParentSurfaceGUID;

		public Vector3 RelativePosition;

		public Quaternion RelativeRotation;

		public SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot)
			: base(default(Guid), null, 0)
		{
		}
	}
}
