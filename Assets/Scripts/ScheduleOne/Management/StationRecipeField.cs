namespace ScheduleOne.Management
{
	public class StationRecipeField : global::ScheduleOne.Management.ConfigField
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> Options;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.StationFramework.StationRecipe> onRecipeChanged;

		public global::ScheduleOne.StationFramework.StationRecipe SelectedRecipe { get; protected set; }

		public StationRecipeField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetRecipe(global::ScheduleOne.StationFramework.StationRecipe recipe, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.StationRecipeFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.StationRecipeFieldData data)
		{
		}
	}
}
