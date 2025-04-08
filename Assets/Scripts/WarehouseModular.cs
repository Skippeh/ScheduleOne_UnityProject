[global::UnityEngine.ExecuteInEditMode]
public class WarehouseModular : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.HideInInspector]
	public global::System.Collections.Generic.List<global::UnityEngine.GameObject> itemsList;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject largeWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject mediumWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject smallWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject miniWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject tinyWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject windowWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject smallWindowWall;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject innerCorner;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject outerCorner;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject garageFrame;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject doorFrame;

	[global::UnityEngine.HideInInspector]
	public global::UnityEngine.GameObject doubleDoorFrame;

	private global::UnityEngine.MeshFilter myMeshFilter;

	private void Start()
	{
	}

	public void BuildNextItem(global::UnityEngine.GameObject item)
	{
	}

	public void DeleteLastItem()
	{
	}
}
