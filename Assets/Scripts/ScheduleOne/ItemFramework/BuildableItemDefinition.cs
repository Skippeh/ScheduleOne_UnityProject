namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "BuildableItemDefinition", menuName = "ScriptableObjects/BuildableItemDefinition", order = 1)]
	public class BuildableItemDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		public enum EBuildSoundType
		{
			Cardboard = 0,
			Wood = 1,
			Metal = 2
		}

		public global::ScheduleOne.EntityFramework.BuildableItem BuiltItem;

		public global::ScheduleOne.ItemFramework.BuildableItemDefinition.EBuildSoundType BuildSoundType;

		public override void ValidateDefinition()
		{
		}
	}
}
