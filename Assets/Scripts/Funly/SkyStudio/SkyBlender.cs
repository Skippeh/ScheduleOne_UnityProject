namespace Funly.SkyStudio
{
	public class SkyBlender : global::Funly.SkyStudio.FeatureBlender
	{
		protected override string featureKey => null;

		protected override global::Funly.SkyStudio.ProfileFeatureBlendingMode BlendingMode(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
			return default(global::Funly.SkyStudio.ProfileFeatureBlendingMode);
		}

		protected override void BlendBoth(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}

		protected override void BlendIn(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}

		protected override void BlendOut(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}
	}
}
