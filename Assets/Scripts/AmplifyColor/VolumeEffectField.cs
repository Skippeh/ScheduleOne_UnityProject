namespace AmplifyColor
{
	[global::System.Serializable]
	public class VolumeEffectField
	{
		public string fieldName;

		public string fieldType;

		public float valueSingle;

		public global::UnityEngine.Color valueColor;

		public bool valueBoolean;

		public global::UnityEngine.Vector2 valueVector2;

		public global::UnityEngine.Vector3 valueVector3;

		public global::UnityEngine.Vector4 valueVector4;

		public VolumeEffectField(string fieldName, string fieldType)
		{
		}

		public VolumeEffectField(global::System.Reflection.FieldInfo pi, global::UnityEngine.Component c)
		{
		}

		public static bool IsValidType(string type)
		{
			return false;
		}

		public void UpdateValue(object val)
		{
		}
	}
}
