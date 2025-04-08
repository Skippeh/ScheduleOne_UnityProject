namespace ScheduleOne.ScriptableObjects
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "StringDatabase", menuName = "ScriptableObjects/StringDatabase", order = 1)]
	public class StringDatabase : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.TextArea(2, 10)]
		public string[] Strings;
	}
}
