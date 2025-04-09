using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Phone
{
	public class CustomerSelector : MonoBehaviour
	{
		public GameObject ButtonPrefab;

		[Header("References")]
		public RectTransform EntriesContainer;

		public UnityEvent<Customer> onCustomerSelected;

		private List<RectTransform> customerEntries;

		private Dictionary<RectTransform, Customer> entryToCustomer;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void CreateEntry(Customer customer)
		{
		}

		private void CustomerSelected(Customer customer)
		{
		}
	}
}
