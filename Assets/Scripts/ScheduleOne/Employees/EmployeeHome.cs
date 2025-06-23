namespace ScheduleOne.Employees
{
	public class EmployeeHome : global::UnityEngine.MonoBehaviour
	{
		public string HomeType;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Clipboard;

		public global::UnityEngine.SpriteRenderer MugshotSprite;

		public global::TMPro.TextMeshPro NameLabel;

		public global::ScheduleOne.Storage.StorageEntity Storage;

		public global::UnityEngine.MeshRenderer[] EmployeeSpecificMeshes;

		public global::UnityEngine.Material SpecificMat_Default;

		public global::UnityEngine.Material SpecificMat_Botanist;

		public global::UnityEngine.Material SpecificMat_Chemist;

		public global::UnityEngine.Material SpecificMat_Packager;

		public global::UnityEngine.Material SpecificMat_Cleaner;

		public global::UnityEngine.Events.UnityEvent onAssignedEmployeeChanged;

		public global::ScheduleOne.Employees.Employee AssignedEmployee { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetAssignedEmployee(global::ScheduleOne.Employees.Employee employee)
		{
		}

		private void UpdateStorageText()
		{
		}

		private void UpdateMaterial()
		{
		}

		public float GetCashSum()
		{
			return 0f;
		}

		public void RemoveCash(float amount)
		{
		}

		public static bool IsBuildableEntityAValidEmployeeHome(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
