namespace SFB
{
	public struct ExtensionFilter
	{
		public string Name;

		public string[] Extensions;

		public ExtensionFilter(string filterName, params string[] filterExtensions)
		{
			Name = null;
			Extensions = null;
		}
	}
}
