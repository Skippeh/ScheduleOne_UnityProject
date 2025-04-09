using System;
using System.Reflection;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectFieldFlags
	{
		public string fieldName;

		public string fieldType;

		public bool blendFlag;

		public VolumeEffectFieldFlags(FieldInfo pi)
		{
		}

		public VolumeEffectFieldFlags(VolumeEffectField field)
		{
		}
	}
}
