namespace ScheduleOne.Product
{
	public class WeedVisualsSetter : global::ScheduleOne.Product.ProductVisualsSetter
	{
		[global::System.Serializable]
		public class MeshMaterialSettings
		{
			public global::UnityEngine.MeshRenderer Mesh;

			public global::System.Collections.Generic.List<global::ScheduleOne.Product.WeedAppearanceSettings.EWeedAppearanceType> Materials;
		}

		public global::ScheduleOne.Product.WeedVisualsSetter.MeshMaterialSettings[] Meshes;

		public override void ApplyVisuals(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}

		private void OnValidate()
		{
		}
	}
}
