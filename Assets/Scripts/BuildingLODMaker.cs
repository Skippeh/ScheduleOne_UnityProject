public class BuildingLODMaker : global::UnityEngine.MonoBehaviour
{
	[global::System.Serializable]
	public class LODGroupData
	{
		public string ObjectName;

		public global::UnityEngine.GameObject LODObject;
	}

	public BuildingLODMaker.LODGroupData[] LODGroups;

	public global::UnityEngine.LODGroup LodGroup;

	[global::EasyButtons.Button]
	public void CreateLODs()
	{
	}
}
