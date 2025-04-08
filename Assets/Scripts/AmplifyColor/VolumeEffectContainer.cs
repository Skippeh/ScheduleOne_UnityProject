namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectContainer
	{
		public global::System.Collections.Generic.List<global::AmplifyColor.VolumeEffect> volumes;

		public void AddColorEffect(AmplifyColorEffect colorEffect)
		{
		}

		public global::AmplifyColor.VolumeEffect AddJustColorEffect(AmplifyColorEffect colorEffect)
		{
			return null;
		}

		public global::AmplifyColor.VolumeEffect FindVolumeEffect(AmplifyColorEffect colorEffect)
		{
			return null;
		}

		public void RemoveVolumeEffect(global::AmplifyColor.VolumeEffect volume)
		{
		}

		public AmplifyColorEffect[] GetStoredEffects()
		{
			return null;
		}
	}
}
