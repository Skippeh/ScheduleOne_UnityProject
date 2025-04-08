namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class BranchNodeData
	{
		public string Guid;

		public string BranchLabel;

		public global::UnityEngine.Vector2 Position;

		public global::ScheduleOne.Dialogue.BranchOptionData[] options;
	}
}
