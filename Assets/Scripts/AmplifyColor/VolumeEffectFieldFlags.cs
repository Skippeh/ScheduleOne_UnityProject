namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectFieldFlags
	{
		public string fieldName;

		public string fieldType;

		public bool blendFlag;

		public VolumeEffectFieldFlags(global::System.Reflection.FieldInfo pi)
		{
		}

		public VolumeEffectFieldFlags(global::AmplifyColor.VolumeEffectField field)
		{
		}
	}
}
