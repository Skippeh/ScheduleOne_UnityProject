namespace ScheduleOne.Management
{
	public class ManagementUtilities : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Management.ManagementUtilities>
	{
		public global::System.Collections.Generic.List<string> weedSeedAssetPaths;

		public global::System.Collections.Generic.List<string> additiveAssetPaths;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.AdditiveDefinition> AdditiveDefinitions;

		public static global::System.Collections.Generic.List<string> WeedSeedAssetPaths => null;

		public static global::System.Collections.Generic.List<string> AdditiveAssetPaths => null;
	}
}
