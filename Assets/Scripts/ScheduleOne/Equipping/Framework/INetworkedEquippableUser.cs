namespace ScheduleOne.Equipping.Framework
{
	public interface INetworkedEquippableUser : global::ScheduleOne.Core.Equipping.Framework.IEquippableUser
	{
		global::FishNet.Object.NetworkBehaviour NetworkBehaviour { get; }

		global::UnityEngine.Transform ItemHandlerContainer => null;

		global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler EquipLocal(global::ScheduleOne.Core.Equipping.Framework.EquippableData equippable);

		global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler EquipLocal(global::ScheduleOne.Core.Items.Framework.BaseItemInstance item);
	}
}
