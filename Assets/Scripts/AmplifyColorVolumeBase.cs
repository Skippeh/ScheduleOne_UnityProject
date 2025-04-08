[global::UnityEngine.ExecuteInEditMode]
[global::UnityEngine.AddComponentMenu("")]
public class AmplifyColorVolumeBase : global::UnityEngine.MonoBehaviour
{
	public global::UnityEngine.Texture2D LutTexture;

	public float Exposure;

	public float EnterBlendTime;

	public int Priority;

	public bool ShowInSceneView;

	[global::UnityEngine.HideInInspector]
	public global::AmplifyColor.VolumeEffectContainer EffectContainer;

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
