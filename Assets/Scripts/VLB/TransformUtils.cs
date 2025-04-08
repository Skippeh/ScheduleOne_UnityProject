namespace VLB
{
	public static class TransformUtils
	{
		public struct Packed
		{
			public global::UnityEngine.Vector3 position;

			public global::UnityEngine.Quaternion rotation;

			public global::UnityEngine.Vector3 lossyScale;

			public bool IsSame(global::UnityEngine.Transform transf)
			{
				return false;
			}
		}

		public static global::VLB.TransformUtils.Packed GetWorldPacked(this global::UnityEngine.Transform self)
		{
			return default(global::VLB.TransformUtils.Packed);
		}
	}
}
