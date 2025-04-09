using AmplifyColor;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("")]
public class AmplifyColorVolumeBase : MonoBehaviour
{
	public Texture2D LutTexture;

	public float Exposure;

	public float EnterBlendTime;

	public int Priority;

	public bool ShowInSceneView;

	[HideInInspector]
	public VolumeEffectContainer EffectContainer;

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
