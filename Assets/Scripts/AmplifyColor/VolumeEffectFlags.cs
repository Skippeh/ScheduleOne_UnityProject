namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectFlags
	{
		public global::System.Collections.Generic.List<global::AmplifyColor.VolumeEffectComponentFlags> components;

		public void AddComponent(global::UnityEngine.Component c)
		{
		}

		public void UpdateFlags(global::AmplifyColor.VolumeEffect effectVol)
		{
		}

		public static void UpdateCamFlags(AmplifyColorEffect[] effects, AmplifyColorVolumeBase[] volumes)
		{
		}

		public global::AmplifyColor.VolumeEffect GenerateEffectData(AmplifyColorEffect go)
		{
			return null;
		}

		public global::AmplifyColor.VolumeEffectComponentFlags FindComponentFlags(string compName)
		{
			return null;
		}

		public string[] GetComponentNames()
		{
			return null;
		}
	}
}
