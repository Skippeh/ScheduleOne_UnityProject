namespace ScheduleOne.Messaging
{
	[global::System.Serializable]
	public class Response
	{
		public string text;

		public string label;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::System.Action callback;

		public bool disableDefaultResponseBehaviour;

		public Response(string _text, string _label, global::System.Action _callback = null, bool _disableDefaultResponseBehaviour = false)
		{
		}

		public Response()
		{
		}
	}
}
