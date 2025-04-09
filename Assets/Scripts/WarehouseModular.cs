using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WarehouseModular : MonoBehaviour
{
	[HideInInspector]
	public List<GameObject> itemsList;

	[HideInInspector]
	public GameObject largeWall;

	[HideInInspector]
	public GameObject mediumWall;

	[HideInInspector]
	public GameObject smallWall;

	[HideInInspector]
	public GameObject miniWall;

	[HideInInspector]
	public GameObject tinyWall;

	[HideInInspector]
	public GameObject windowWall;

	[HideInInspector]
	public GameObject smallWindowWall;

	[HideInInspector]
	public GameObject innerCorner;

	[HideInInspector]
	public GameObject outerCorner;

	[HideInInspector]
	public GameObject garageFrame;

	[HideInInspector]
	public GameObject doorFrame;

	[HideInInspector]
	public GameObject doubleDoorFrame;

	private MeshFilter myMeshFilter;

	private void Start()
	{
	}

	public void BuildNextItem(GameObject item)
	{
	}

	public void DeleteLastItem()
	{
	}
}
