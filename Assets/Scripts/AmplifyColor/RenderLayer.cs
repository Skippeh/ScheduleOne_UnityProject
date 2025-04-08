namespace AmplifyColor
{
	[global::System.Serializable]
	public struct RenderLayer
	{
		public global::UnityEngine.LayerMask mask;

		public global::UnityEngine.Color color;

		public RenderLayer(global::UnityEngine.LayerMask mask, global::UnityEngine.Color color)
		{
			this.mask = default(global::UnityEngine.LayerMask);
			this.color = default(global::UnityEngine.Color);
		}
	}
}
