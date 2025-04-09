using System;
using System.Collections.Generic;
using ScheduleOne;

public static class GUIDManager
{
	private static List<Guid> registeredGUIDs;

	private static Dictionary<Guid, object> guidToObject;

	public static void RegisterObject(IGUIDRegisterable obj)
	{
	}

	public static void DeregisterObject(IGUIDRegisterable obj)
	{
	}

	public static T GetObject<T>(Guid guid)
	{
		return default(T);
	}

	public static Type GetObjectType(Guid guid)
	{
		return null;
	}

	public static Guid GenerateUniqueGUID()
	{
		return default(Guid);
	}

	public static bool IsGUIDAlreadyRegistered(Guid guid)
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
