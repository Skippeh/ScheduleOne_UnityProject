using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WaterPipeModular : MonoBehaviour
{
	[HideInInspector]
	public List<GameObject> itemsList;

	[HideInInspector]
	public GameObject largeWaterPipe;

	[HideInInspector]
	public GameObject mediumWaterPipe;

	[HideInInspector]
	public GameObject smallWaterpipe;

	[HideInInspector]
	public GameObject innerCorner;

	[HideInInspector]
	public GameObject outerCorner;

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
