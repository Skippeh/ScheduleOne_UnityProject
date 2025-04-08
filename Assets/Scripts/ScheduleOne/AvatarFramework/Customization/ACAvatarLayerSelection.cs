namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACAvatarLayerSelection : global::ScheduleOne.AvatarFramework.Customization.ACSelection<global::ScheduleOne.AvatarFramework.AvatarLayer>
	{
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		public override void CallValueChange()
		{
		}

		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}
	}
}
