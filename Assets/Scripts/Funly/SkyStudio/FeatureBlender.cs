namespace Funly.SkyStudio
{
	public abstract class FeatureBlender : global::UnityEngine.MonoBehaviour, global::Funly.SkyStudio.IFeatureBlender
	{
		protected abstract string featureKey { get; }

		protected abstract void BlendBoth(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper);

		protected abstract void BlendIn(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper);

		protected abstract void BlendOut(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper);

		protected virtual global::Funly.SkyStudio.ProfileFeatureBlendingMode BlendingMode(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
			return default(global::Funly.SkyStudio.ProfileFeatureBlendingMode);
		}

		public virtual void Blend(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}
	}
}
