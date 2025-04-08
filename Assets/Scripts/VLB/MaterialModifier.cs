namespace VLB
{
	public static class MaterialModifier
	{
		public interface Interface
		{
			void SetMaterialProp(int nameID, float value);

			void SetMaterialProp(int nameID, global::UnityEngine.Vector4 value);

			void SetMaterialProp(int nameID, global::UnityEngine.Color value);

			void SetMaterialProp(int nameID, global::UnityEngine.Matrix4x4 value);

			void SetMaterialProp(int nameID, global::UnityEngine.Texture value);
		}

		public delegate void Callback(global::VLB.MaterialModifier.Interface owner);
	}
}
