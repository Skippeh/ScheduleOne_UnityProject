namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffect
	{
		public AmplifyColorEffect gameObject;

		public global::System.Collections.Generic.List<global::AmplifyColor.VolumeEffectComponent> components;

		public VolumeEffect(AmplifyColorEffect effect)
		{
		}

		public static global::AmplifyColor.VolumeEffect BlendValuesToVolumeEffect(global::AmplifyColor.VolumeEffectFlags flags, global::AmplifyColor.VolumeEffect volume1, global::AmplifyColor.VolumeEffect volume2, float blend)
		{
			return null;
		}

		public global::AmplifyColor.VolumeEffectComponent AddComponent(global::UnityEngine.Component c, global::AmplifyColor.VolumeEffectComponentFlags compFlags)
		{
			return null;
		}

		public void RemoveEffectComponent(global::AmplifyColor.VolumeEffectComponent comp)
		{
		}

		public void UpdateVolume()
		{
		}

		public void SetValues(AmplifyColorEffect targetColor)
		{
		}

		public void BlendValues(AmplifyColorEffect targetColor, global::AmplifyColor.VolumeEffect other, float blendAmount)
		{
		}

		public global::AmplifyColor.VolumeEffectComponent FindEffectComponent(string compName)
		{
			return null;
		}

		public static global::UnityEngine.Component[] ListAcceptableComponents(AmplifyColorEffect go)
		{
			return null;
		}

		public string[] GetComponentNames()
		{
			return null;
		}
	}
}
