using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectComponentFlags
	{
		public string componentName;

		public List<VolumeEffectFieldFlags> componentFields;

		public bool blendFlag;

		public VolumeEffectComponentFlags(string name)
		{
		}

		public VolumeEffectComponentFlags(VolumeEffectComponent comp)
		{
		}

		public VolumeEffectComponentFlags(Component c)
		{
		}

		public void UpdateComponentFlags(VolumeEffectComponent comp)
		{
		}

		public void UpdateComponentFlags(Component c)
		{
		}

		public string[] GetFieldNames()
		{
			return null;
		}
	}
}
