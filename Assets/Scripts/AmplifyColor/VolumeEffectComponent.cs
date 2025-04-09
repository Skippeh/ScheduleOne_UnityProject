using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectComponent
	{
		public string componentName;

		public List<VolumeEffectField> fields;

		public VolumeEffectComponent(string name)
		{
		}

		public VolumeEffectField AddField(FieldInfo pi, Component c)
		{
			return null;
		}

		public VolumeEffectField AddField(FieldInfo pi, Component c, int position)
		{
			return null;
		}

		public void RemoveEffectField(VolumeEffectField field)
		{
		}

		public VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
		}

		public void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
		}

		public VolumeEffectField FindEffectField(string fieldName)
		{
			return null;
		}

		public static FieldInfo[] ListAcceptableFields(Component c)
		{
			return null;
		}

		public string[] GetFieldNames()
		{
			return null;
		}
	}
}
