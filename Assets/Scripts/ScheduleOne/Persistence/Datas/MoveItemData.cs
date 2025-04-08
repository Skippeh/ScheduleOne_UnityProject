namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MoveItemData
	{
		public string TemplateItemJSON;

		public int GrabbedItemQuantity;

		public string SourceGUID;

		public string DestinationGUID;

		public MoveItemData(string templateItemJson, int grabbedItemQuantity, global::System.Guid sourceGUID, global::System.Guid destinationGUID)
		{
		}
	}
}
