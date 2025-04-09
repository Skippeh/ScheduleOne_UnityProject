using UnityEngine;

namespace VLB
{
	public static class TransformUtils
	{
		public struct Packed
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 lossyScale;

			public bool IsSame(Transform transf)
			{
				return false;
			}
		}

		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
}
