namespace ScheduleOne.Money
{
	public class Transaction
	{
		public string transaction_Name;

		public float unit_Amount;

		public float quantity;

		public string transaction_Note;

		public float total_Amount => 0f;

		public Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}
	}
}
