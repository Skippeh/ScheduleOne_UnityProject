namespace ScheduleOne.DevUtilities
{
	public class SceneUtility : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Afinity Settings")]
		public global::ScheduleOne.Product.EDrugType DrugAffinityToAdd;

		public global::UnityEngine.Vector2 MinMaxAffinityRange;

		public bool UseCurrentHighestAffinityAsMax;

		[global::UnityEngine.Header("Objects to Modify")]
		public global::System.Collections.Generic.List<global::UnityEngine.Transform> SceneObjects;

		[global::EasyButtons.Button]
		public void AddAffinityAndRandomise()
		{
		}

		[global::EasyButtons.Button]
		public void RemoveAffinity()
		{
		}
	}
}
