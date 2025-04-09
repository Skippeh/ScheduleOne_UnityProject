using UnityEngine;

namespace Funly.SkyStudio
{
	public abstract class FeatureBlender : MonoBehaviour, IFeatureBlender
	{
		protected abstract string featureKey { get; }

		protected abstract void BlendBoth(ProfileBlendingState state, BlendingHelper helper);

		protected abstract void BlendIn(ProfileBlendingState state, BlendingHelper helper);

		protected abstract void BlendOut(ProfileBlendingState state, BlendingHelper helper);

		protected virtual ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			return default(ProfileFeatureBlendingMode);
		}

		public virtual void Blend(ProfileBlendingState state, BlendingHelper helper)
		{
		}
	}
}
