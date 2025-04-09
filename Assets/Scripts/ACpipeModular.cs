using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ACpipeModular : MonoBehaviour
{
	[HideInInspector]
	public List<GameObject> itemsList;

	[HideInInspector]
	public GameObject largeACPipe;

	[HideInInspector]
	public GameObject smallACpipe;

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
