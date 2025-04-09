using System;
using EasyButtons;
using UnityEngine;

public class BuildingLODMaker : MonoBehaviour
{
	[Serializable]
	public class LODGroupData
	{
		public string ObjectName;

		public GameObject LODObject;
	}

	public LODGroupData[] LODGroups;

	public LODGroup LodGroup;

	[Button]
	public void CreateLODs()
	{
	}
}
