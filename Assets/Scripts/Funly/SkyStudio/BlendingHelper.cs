namespace Funly.SkyStudio
{
	public class BlendingHelper
	{
		private global::Funly.SkyStudio.ProfileBlendingState m_State;

		public BlendingHelper(global::Funly.SkyStudio.ProfileBlendingState state)
		{
		}

		public void UpdateState(global::Funly.SkyStudio.ProfileBlendingState state)
		{
		}

		public global::UnityEngine.Color ProfileColorForKey(global::Funly.SkyStudio.SkyProfile profile, string key)
		{
			return default(global::UnityEngine.Color);
		}

		public float ProfileNumberForKey(global::Funly.SkyStudio.SkyProfile profile, string key)
		{
			return 0f;
		}

		public global::Funly.SkyStudio.SpherePoint ProfileSpherePointForKey(global::Funly.SkyStudio.SkyProfile profile, string key)
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

		public void BlendColor(string key, global::UnityEngine.Color from, global::UnityEngine.Color to, float progress)
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

		public void BlendSpherePoint(string key, global::Funly.SkyStudio.SpherePoint from, global::Funly.SkyStudio.SpherePoint to, float progress)
		{
		}

		public global::Funly.SkyStudio.ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			return default(global::Funly.SkyStudio.ProfileFeatureBlendingMode);
		}
	}
}
