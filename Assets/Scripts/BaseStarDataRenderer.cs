using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class BaseStarDataRenderer
{
	public delegate void StarDataProgress(BaseStarDataRenderer renderer, float progress);

	public delegate void StarDataComplete(BaseStarDataRenderer renderer, Texture2D texture, bool success);

	public float density;

	public float imageSize;

	public string layerId;

	public float maxRadius;

	protected float sphereRadius;

	protected bool isCancelled;

	public event StarDataProgress progressCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event StarDataComplete completionCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public abstract IEnumerator ComputeStarData();

	public virtual void Cancel()
	{
	}

	protected void SendProgress(float progress)
	{
	}

	protected void SendCompletion(Texture2D texture, bool success)
	{
	}
}
