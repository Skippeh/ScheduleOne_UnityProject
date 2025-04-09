using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectFlags
	{
		public List<VolumeEffectComponentFlags> components;

		public void AddComponent(Component c)
		{
		}

		public void UpdateFlags(VolumeEffect effectVol)
		{
		}

		public static void UpdateCamFlags(AmplifyColorEffect[] effects, AmplifyColorVolumeBase[] volumes)
		{
		}

		public VolumeEffect GenerateEffectData(AmplifyColorEffect go)
		{
			return null;
		}

		public VolumeEffectComponentFlags FindComponentFlags(string compName)
		{
			return null;
		}

		public string[] GetComponentNames()
		{
			return null;
		}
	}
}
