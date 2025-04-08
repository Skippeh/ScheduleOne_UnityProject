[global::UnityEngine.ExecuteInEditMode]
[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
[global::UnityEngine.RequireComponent(typeof(AmplifyColorEffect))]
[global::UnityEngine.AddComponentMenu("Image Effects/Amplify Color Render Mask")]
public class AmplifyColorRenderMask : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Serialization.FormerlySerializedAs("clearColor")]
	public global::UnityEngine.Color ClearColor;

	[global::UnityEngine.Serialization.FormerlySerializedAs("renderLayers")]
	public global::AmplifyColor.RenderLayer[] RenderLayers;

	[global::UnityEngine.Serialization.FormerlySerializedAs("debug")]
	public bool DebugMask;

	private global::UnityEngine.Camera referenceCamera;

	private global::UnityEngine.Camera maskCamera;

	private AmplifyColorEffect colorEffect;

	private int width;

	private int height;

	private global::UnityEngine.RenderTexture maskTexture;

	private global::UnityEngine.Shader colorMaskShader;

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
