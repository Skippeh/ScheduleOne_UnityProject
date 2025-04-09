using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CircularTextMeshPro : MonoBehaviour
{
	[SerializeField]
	private TMP_Text text;

	public AnimationCurve vertexCurve;

	public float yCurveScaling;

	private bool isForceUpdatingMesh;

	private void Reset()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	private void ReactToTextChanged(Object obj)
	{
	}

	private void WarpText()
	{
	}
}
