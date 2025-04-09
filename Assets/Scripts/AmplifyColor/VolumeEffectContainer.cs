using System;
using System.Collections.Generic;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectContainer
	{
		public List<VolumeEffect> volumes;

		public void AddColorEffect(AmplifyColorEffect colorEffect)
		{
		}

		public VolumeEffect AddJustColorEffect(AmplifyColorEffect colorEffect)
		{
			return null;
		}

		public VolumeEffect FindVolumeEffect(AmplifyColorEffect colorEffect)
		{
			return null;
		}

		public void RemoveVolumeEffect(VolumeEffect volume)
		{
		}

		public AmplifyColorEffect[] GetStoredEffects()
		{
			return null;
		}
	}
}
