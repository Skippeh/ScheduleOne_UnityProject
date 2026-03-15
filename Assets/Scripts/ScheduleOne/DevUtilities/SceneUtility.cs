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

		[global::UnityEngine.Header("Finding Shaders")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _rootObject;

		[global::UnityEngine.SerializeField]
		private bool _showCountOnly;

		[global::ScheduleOne.Core.Button]
		public void ScanSceneForShaders()
		{
		}

		[global::ScheduleOne.Core.Button]
		public void AddAffinityAndRandomise()
		{
		}

		[global::ScheduleOne.Core.Button]
		public void RemoveAffinity()
		{
		}
	}
}
