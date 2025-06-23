namespace SFB
{
	public class WindowWrapper : global::System.Windows.Forms.IWin32Window
	{
		private global::System.IntPtr _hwnd;

		public global::System.IntPtr Handle => (global::System.IntPtr)0;

		public WindowWrapper(global::System.IntPtr handle)
		{
		}
	}
}

// Added to fix build errors (hacky fix but likely doesn't matter for the purposes of this project)
namespace System.Windows.Forms
{
	public interface IWin32Window
	{
		global::System.IntPtr Handle { get; }
	}
}