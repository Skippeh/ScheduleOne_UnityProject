namespace Funly.SkyStudio
{
	public class StarBlender : global::Funly.SkyStudio.FeatureBlender
	{
		[global::UnityEngine.Range(1f, 3f)]
		public int starLayer;

		protected override string featureKey => null;

		protected override void BlendBoth(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}

		protected override void BlendIn(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}

		protected override void BlendOut(global::Funly.SkyStudio.ProfileBlendingState state, global::Funly.SkyStudio.BlendingHelper helper)
		{
		}

		private string PropertyKeyForLayer(string key)
		{
			return null;
		}
	}
}
