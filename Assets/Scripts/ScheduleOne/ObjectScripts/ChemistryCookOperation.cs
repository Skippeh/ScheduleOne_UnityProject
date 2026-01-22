namespace ScheduleOne.ObjectScripts
{
	public class ChemistryCookOperation
	{
		[global::FishNet.Serializing.Helping.CodegenExclude]
		private global::ScheduleOne.StationFramework.StationRecipe recipe;

		public string RecipeID;

		public global::ScheduleOne.ItemFramework.EQuality ProductQuality;

		public global::UnityEngine.Color StartLiquidColor;

		public float LiquidLevel;

		public int CurrentTime;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.StationFramework.StationRecipe Recipe => null;

		public ChemistryCookOperation(global::ScheduleOne.StationFramework.StationRecipe recipe, global::ScheduleOne.ItemFramework.EQuality productQuality, global::UnityEngine.Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		public ChemistryCookOperation(string recipeID, global::ScheduleOne.ItemFramework.EQuality productQuality, global::UnityEngine.Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
		}

		public ChemistryCookOperation()
		{
		}

		public void Progress(int mins)
		{
		}

		public bool IsComplete()
		{
			return false;
		}
	}
}
