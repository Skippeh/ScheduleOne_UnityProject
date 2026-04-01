namespace ScheduleOne.Tools
{
	public class FloatStack
	{
		public enum EStackMode
		{
			Additive = 0,
			Override = 1,
			Multiplicative = 2
		}

		public class StackEntry
		{
			public string Label { get; private set; }

			public float Value { get; private set; }

			public global::ScheduleOne.Tools.FloatStack.EStackMode Mode { get; private set; }

			public int Order { get; private set; }

			public StackEntry(string label, float value, global::ScheduleOne.Tools.FloatStack.EStackMode mode, int order)
			{
			}
		}

		private float _defaultValue;

		private global::System.Collections.Generic.List<global::ScheduleOne.Tools.FloatStack.StackEntry> _stack;

		public float Value { get; private set; }

		public event global::System.Action<float> OnValueChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public FloatStack(float defaultValue)
		{
		}

		public void Add(global::ScheduleOne.Tools.FloatStack.StackEntry entry)
		{
		}

		public void Remove(string label)
		{
		}

		public bool TryGetEntry(string label, out global::ScheduleOne.Tools.FloatStack.StackEntry entry)
		{
			entry = null;
			return false;
		}

		private void Recalculate()
		{
		}
	}
}
