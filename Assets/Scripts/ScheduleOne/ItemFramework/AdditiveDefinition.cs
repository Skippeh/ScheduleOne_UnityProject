namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "AdditiveDefinition", menuName = "ScriptableObjects/Item Definitions/AdditiveDefinition", order = 1)]
	public class AdditiveDefinition : global::ScheduleOne.ItemFramework.StorableItemDefinition
	{
		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Material DisplayMaterial { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float QualityChange { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float YieldMultiplier { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float InstantGrowth { get; private set; }

		public override void ValidateDefinition()
		{
		}
	}
}
