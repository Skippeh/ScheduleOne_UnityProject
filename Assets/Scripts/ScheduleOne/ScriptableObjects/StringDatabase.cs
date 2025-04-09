using System;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	[Serializable]
	[CreateAssetMenu(fileName = "StringDatabase", menuName = "ScriptableObjects/StringDatabase", order = 1)]
	public class StringDatabase : ScriptableObject
	{
		[TextArea(2, 10)]
		public string[] Strings;
	}
}
