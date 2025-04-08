namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_Base : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.ConstructableScripts.Constructable_GridBased MovedConstructable;

		public bool isMoving => false;

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public virtual void ConstructionStop()
		{
		}
	}
}
