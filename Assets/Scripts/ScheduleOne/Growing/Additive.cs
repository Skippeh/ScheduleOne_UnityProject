namespace ScheduleOne.Growing
{
	public class Additive : global::UnityEngine.MonoBehaviour
	{
		public string AdditiveName;

		public global::ScheduleOne.ItemFramework.AdditiveDefinition Definition;

		[global::UnityEngine.Header("Plant effector settings")]
		public float QualityChange;

		public float YieldChange;

		public float GrowSpeedMultiplier;

		public float InstantGrowth;
	}
}
