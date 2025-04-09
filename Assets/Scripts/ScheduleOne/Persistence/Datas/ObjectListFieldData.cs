using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ObjectListFieldData
	{
		public List<string> ObjectGUIDs;

		public ObjectListFieldData(List<string> objectGUIDs)
		{
		}
	}
}
