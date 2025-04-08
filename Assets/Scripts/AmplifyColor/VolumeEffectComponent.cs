namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectComponent
	{
		public string componentName;

		public global::System.Collections.Generic.List<global::AmplifyColor.VolumeEffectField> fields;

		public VolumeEffectComponent(string name)
		{
		}

		public global::AmplifyColor.VolumeEffectField AddField(global::System.Reflection.FieldInfo pi, global::UnityEngine.Component c)
		{
			return null;
		}

		public global::AmplifyColor.VolumeEffectField AddField(global::System.Reflection.FieldInfo pi, global::UnityEngine.Component c, int position)
		{
			return null;
		}

		public void RemoveEffectField(global::AmplifyColor.VolumeEffectField field)
		{
		}

		public VolumeEffectComponent(global::UnityEngine.Component c, global::AmplifyColor.VolumeEffectComponentFlags compFlags)
		{
		}

		public void UpdateComponent(global::UnityEngine.Component c, global::AmplifyColor.VolumeEffectComponentFlags compFlags)
		{
		}

		public global::AmplifyColor.VolumeEffectField FindEffectField(string fieldName)
		{
			return null;
		}

		public static global::System.Reflection.FieldInfo[] ListAcceptableFields(global::UnityEngine.Component c)
		{
			return null;
		}

		public string[] GetFieldNames()
		{
			return null;
		}
	}
}
