public abstract class BaseStarDataRenderer
{
	public delegate void StarDataProgress(BaseStarDataRenderer renderer, float progress);

	public delegate void StarDataComplete(BaseStarDataRenderer renderer, global::UnityEngine.Texture2D texture, bool success);

	public float density;

	public float imageSize;

	public string layerId;

	public float maxRadius;

	protected float sphereRadius;

	protected bool isCancelled;

	public event BaseStarDataRenderer.StarDataProgress progressCallback
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		add
		{
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		remove
		{
		}
	}

	public event BaseStarDataRenderer.StarDataComplete completionCallback
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		add
		{
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		remove
		{
		}
	}

	public abstract global::System.Collections.IEnumerator ComputeStarData();

	public virtual void Cancel()
	{
	}

	protected void SendProgress(float progress)
	{
	}

	protected void SendCompletion(global::UnityEngine.Texture2D texture, bool success)
	{
	}
}
