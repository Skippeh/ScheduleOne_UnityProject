namespace ScheduleOne.DevUtilities
{
	public class LODAdjuster : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.LODGroup _lodGroup;

		[global::UnityEngine.Header("LOD Settings")]
		[global::UnityEngine.SerializeField]
		private string _rendererName;

		[global::UnityEngine.SerializeField]
		private int _lodLevel;

		[global::EasyButtons.Button]
		public void AddToLodGroup()
		{
		}
	}
}
