using AmplifyColor;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(AmplifyColorEffect))]
[AddComponentMenu("Image Effects/Amplify Color Render Mask")]
public class AmplifyColorRenderMask : MonoBehaviour
{
	[FormerlySerializedAs("clearColor")]
	public Color ClearColor;

	[FormerlySerializedAs("renderLayers")]
	public RenderLayer[] RenderLayers;

	[FormerlySerializedAs("debug")]
	public bool DebugMask;

	private Camera referenceCamera;

	private Camera maskCamera;

	private AmplifyColorEffect colorEffect;

	private int width;

	private int height;

	private RenderTexture maskTexture;

	private Shader colorMaskShader;

	private bool singlePassStereo;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void DestroyCamera()
	{
	}

	private void DestroyRenderTextures()
	{
	}

	private void UpdateRenderTextures(bool singlePassStereo)
	{
	}

	private void UpdateCameraProperties()
	{
	}

	private void OnPreRender()
	{
	}
}
