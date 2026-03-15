namespace ScheduleOne.Equipping.Framework
{
	public static class EquippableHandlerService
	{
		private class HandlerInfo
		{
			public global::System.Type DataType;

			public global::System.Type HandlerType;

			public HandlerInfo(global::System.Type dataType, global::System.Type handlerType)
			{
			}
		}

		private static global::ScheduleOne.Equipping.Framework.EquipConfiguration _configuration;

		private static global::System.Collections.Generic.List<global::ScheduleOne.Equipping.Framework.EquippableHandlerService.HandlerInfo> _defaultHandlers;

		static EquippableHandlerService()
		{
		}

		private static void SetupHandlerKeys()
		{
		}

		public static global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler GetHandlerPrefab(global::ScheduleOne.Core.Equipping.Framework.EquippableData equippedData)
		{
			return null;
		}
	}
}
