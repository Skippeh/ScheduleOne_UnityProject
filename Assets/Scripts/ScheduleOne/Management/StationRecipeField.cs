using System.Collections.Generic;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class StationRecipeField : ConfigField
	{
		public List<StationRecipe> Options;

		public UnityEvent<StationRecipe> onRecipeChanged;

		public StationRecipe SelectedRecipe { get; protected set; }

		public StationRecipeField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetRecipe(StationRecipe recipe, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public StationRecipeFieldData GetData()
		{
			return null;
		}

		public void Load(StationRecipeFieldData data)
		{
		}
	}
}
