using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MoveItemData
	{
		public string TemplateItemJSON;

		public int GrabbedItemQuantity;

		public string SourceGUID;

		public string DestinationGUID;

		public MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID)
		{
		}
	}
}
