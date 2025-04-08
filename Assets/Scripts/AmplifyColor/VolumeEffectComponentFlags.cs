namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectComponentFlags
	{
		public string componentName;

		public global::System.Collections.Generic.List<global::AmplifyColor.VolumeEffectFieldFlags> componentFields;

		public bool blendFlag;

		public VolumeEffectComponentFlags(string name)
		{
		}

		public VolumeEffectComponentFlags(global::AmplifyColor.VolumeEffectComponent comp)
		{
		}

		public VolumeEffectComponentFlags(global::UnityEngine.Component c)
		{
		}

		public void UpdateComponentFlags(global::AmplifyColor.VolumeEffectComponent comp)
		{
		}

		public void UpdateComponentFlags(global::UnityEngine.Component c)
		{
		}

		public string[] GetFieldNames()
		{
			return null;
		}
	}
}
