public static class GUIDManager
{
	private static global::System.Collections.Generic.List<global::System.Guid> registeredGUIDs;

	private static global::System.Collections.Generic.Dictionary<global::System.Guid, object> guidToObject;

	public static void RegisterObject(global::ScheduleOne.IGUIDRegisterable obj, global::UnityEngine.GameObject go = null)
	{
	}

	public static void DeregisterObject(global::ScheduleOne.IGUIDRegisterable obj)
	{
	}

	public static T GetObject<T>(global::System.Guid guid)
	{
		return default(T);
	}

	public static global::System.Type GetObjectType(global::System.Guid guid)
	{
		return null;
	}

	public static global::System.Guid GenerateUniqueGUID()
	{
		return default(global::System.Guid);
	}

	public static bool IsGUIDAlreadyRegistered(global::System.Guid guid)
	{
		return false;
	}

	public static bool IsGUIDValid(string guid)
	{
		return false;
	}

	public static void Clear()
	{
	}
}
