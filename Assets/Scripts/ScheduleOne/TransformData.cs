namespace ScheduleOne
{
	public struct TransformData
	{
		public global::UnityEngine.Vector3 Position;

		public global::UnityEngine.Quaternion Rotation;

		public global::UnityEngine.Vector3 Scale;

		public TransformData(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 scale)
		{
			Position = default(global::UnityEngine.Vector3);
			Rotation = default(global::UnityEngine.Quaternion);
			Scale = default(global::UnityEngine.Vector3);
		}

		public void ApplyToWorldTransform(global::UnityEngine.Transform transform)
		{
		}

		public void ApplyToLocalTransform(global::UnityEngine.Transform transform, bool setScale = true)
		{
		}

		public static global::ScheduleOne.TransformData FromTransform(global::UnityEngine.Transform transform)
		{
			return default(global::ScheduleOne.TransformData);
		}

		public static global::ScheduleOne.TransformData Lerp(global::ScheduleOne.TransformData a, global::ScheduleOne.TransformData b, float t)
		{
			return default(global::ScheduleOne.TransformData);
		}
	}
}
