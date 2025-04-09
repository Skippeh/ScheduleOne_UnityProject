using UnityEngine;

namespace Funly.SkyStudio
{
	public class BlendingHelper
	{
		private ProfileBlendingState m_State;

		public BlendingHelper(ProfileBlendingState state)
		{
		}

		public void UpdateState(ProfileBlendingState state)
		{
		}

		public Color ProfileColorForKey(SkyProfile profile, string key)
		{
			return default(Color);
		}

		public float ProfileNumberForKey(SkyProfile profile, string key)
		{
			return 0f;
		}

		public SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key)
		{
			return null;
		}

		public void BlendColor(string key)
		{
		}

		public void BlendColorOut(string key)
		{
		}

		public void BlendColorIn(string key)
		{
		}

		public void BlendColor(string key, Color from, Color to, float progress)
		{
		}

		public void BlendNumber(string key)
		{
		}

		public void BlendNumberOut(string key, float toValue = 0f)
		{
		}

		public void BlendNumberIn(string key, float fromValue = 0f)
		{
		}

		public void BlendNumber(string key, float from, float to, float progress)
		{
		}

		public void BlendSpherePoint(string key)
		{
		}

		public void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress)
		{
		}

		public ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			return default(ProfileFeatureBlendingMode);
		}
	}
}
