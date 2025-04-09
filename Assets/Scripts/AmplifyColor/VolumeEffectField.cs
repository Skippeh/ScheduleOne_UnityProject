using System;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectField
	{
		public string fieldName;

		public string fieldType;

		public float valueSingle;

		public Color valueColor;

		public bool valueBoolean;

		public Vector2 valueVector2;

		public Vector3 valueVector3;

		public Vector4 valueVector4;

		public VolumeEffectField(string fieldName, string fieldType)
		{
		}

		public VolumeEffectField(FieldInfo pi, Component c)
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
