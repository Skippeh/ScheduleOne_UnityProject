using UnityEngine;

namespace Funly.SkyStudio
{
	public class StarBlender : FeatureBlender
	{
		[Range(1f, 3f)]
		public int starLayer;

		protected override string featureKey => null;

		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		private string PropertyKeyForLayer(string key)
		{
			return null;
		}
	}
}
