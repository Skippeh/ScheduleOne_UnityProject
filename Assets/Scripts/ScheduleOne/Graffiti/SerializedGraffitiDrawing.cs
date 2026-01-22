namespace ScheduleOne.Graffiti
{
	[global::UnityEngine.CreateAssetMenu(fileName = "Graffiti Drawing", menuName = "Serialized Graffiti Drawing", order = 1)]
	public class SerializedGraffitiDrawing : global::UnityEngine.ScriptableObject
	{
		[field: global::UnityEngine.SerializeField]
		public string DrawingName { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public int Width { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public int Height { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> Strokes { get; private set; }

		public void SetDrawingName(string name)
		{
		}

		public void SetStrokes(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes)
		{
		}

		private void RecalculateSize()
		{
		}
	}
}
