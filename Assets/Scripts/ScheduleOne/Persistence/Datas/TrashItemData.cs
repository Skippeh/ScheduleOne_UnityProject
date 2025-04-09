using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TrashItemData : SaveData
	{
		public string TrashID;

		public string GUID;

		public Vector3 Position;

		public Quaternion Rotation;

		public TrashContentData Contents;

		public TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation)
		{
		}
	}
}
