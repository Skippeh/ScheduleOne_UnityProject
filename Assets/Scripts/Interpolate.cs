public class Interpolate
{
	public enum EaseType
	{
		Linear = 0,
		EaseInQuad = 1,
		EaseOutQuad = 2,
		EaseInOutQuad = 3,
		EaseInCubic = 4,
		EaseOutCubic = 5,
		EaseInOutCubic = 6,
		EaseInQuart = 7,
		EaseOutQuart = 8,
		EaseInOutQuart = 9,
		EaseInQuint = 10,
		EaseOutQuint = 11,
		EaseInOutQuint = 12,
		EaseInSine = 13,
		EaseOutSine = 14,
		EaseInOutSine = 15,
		EaseInExpo = 16,
		EaseOutExpo = 17,
		EaseInOutExpo = 18,
		EaseInCirc = 19,
		EaseOutCirc = 20,
		EaseInOutCirc = 21
	}

	public delegate global::UnityEngine.Vector3 ToVector3<T>(T v);

	public delegate float Function(float a, float b, float c, float d);

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CNewBezier_003Ed__16<T> : global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private global::UnityEngine.Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private global::System.Collections.IList nodes;

		public global::System.Collections.IList _003C_003E3__nodes;

		private global::System.Collections.Generic.IEnumerable<float> steps;

		public global::System.Collections.Generic.IEnumerable<float> _003C_003E3__steps;

		private Interpolate.ToVector3<T> toVector3;

		public Interpolate.ToVector3<T> _003C_003E3__toVector3;

		private Interpolate.Function ease;

		public Interpolate.Function _003C_003E3__ease;

		private float maxStep;

		public float _003C_003E3__maxStep;

		private global::UnityEngine.Vector3[] _003Cpoints_003E5__2;

		private global::System.Collections.Generic.IEnumerator<float> _003C_003E7__wrap2;

		global::UnityEngine.Vector3 global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return default(global::UnityEngine.Vector3);
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CNewBezier_003Ed__16(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3> global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CNewCatmullRom_003Ed__20<T> : global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private global::UnityEngine.Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private global::System.Collections.IList nodes;

		public global::System.Collections.IList _003C_003E3__nodes;

		private Interpolate.ToVector3<T> toVector3;

		public Interpolate.ToVector3<T> _003C_003E3__toVector3;

		private bool loop;

		public bool _003C_003E3__loop;

		private int slices;

		public int _003C_003E3__slices;

		private int _003Clast_003E5__2;

		private int _003Ccurrent_003E5__3;

		private int _003Cprevious_003E5__4;

		private int _003Cstart_003E5__5;

		private int _003Cend_003E5__6;

		private int _003Cnext_003E5__7;

		private int _003CstepCount_003E5__8;

		private int _003Cstep_003E5__9;

		global::UnityEngine.Vector3 global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return default(global::UnityEngine.Vector3);
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CNewCatmullRom_003Ed__20(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.Generic.IEnumerator<global::UnityEngine.Vector3> global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CNewCounter_003Ed__6 : global::System.Collections.Generic.IEnumerable<float>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<float>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int start;

		public int _003C_003E3__start;

		private int step;

		public int _003C_003E3__step;

		private int end;

		public int _003C_003E3__end;

		private int _003Ci_003E5__2;

		float global::System.Collections.Generic.IEnumerator<float>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CNewCounter_003Ed__6(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.Generic.IEnumerator<float> global::System.Collections.Generic.IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CNewEase_003Ed__9 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public global::UnityEngine.Vector3 end;

		public global::UnityEngine.Vector3 start;

		public global::System.Collections.Generic.IEnumerable<float> driver;

		public Interpolate.Function ease;

		public float total;

		private global::UnityEngine.Vector3 _003Cdistance_003E5__2;

		private global::System.Collections.Generic.IEnumerator<float> _003C_003E7__wrap2;

		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CNewEase_003Ed__9(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CNewTimer_003Ed__3 : global::System.Collections.Generic.IEnumerable<float>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<float>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private float duration;

		public float _003C_003E3__duration;

		private float _003CelapsedTime_003E5__2;

		float global::System.Collections.Generic.IEnumerator<float>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CNewTimer_003Ed__3(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.Generic.IEnumerator<float> global::System.Collections.Generic.IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[global::System.Diagnostics.DebuggerHidden]
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private static global::UnityEngine.Vector3 Identity(global::UnityEngine.Vector3 v)
	{
		return default(global::UnityEngine.Vector3);
	}

	private static global::UnityEngine.Vector3 TransformDotPosition(global::UnityEngine.Transform t)
	{
		return default(global::UnityEngine.Vector3);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Interpolate._003CNewTimer_003Ed__3))]
	private static global::System.Collections.Generic.IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Interpolate._003CNewCounter_003Ed__6))]
	private static global::System.Collections.Generic.IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	public static global::System.Collections.IEnumerator NewEase(Interpolate.Function ease, global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float duration)
	{
		return null;
	}

	public static global::System.Collections.IEnumerator NewEase(Interpolate.Function ease, global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, int slices)
	{
		return null;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Interpolate._003CNewEase_003Ed__9))]
	private static global::System.Collections.IEnumerator NewEase(Interpolate.Function ease, global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float total, global::System.Collections.Generic.IEnumerable<float> driver)
	{
		return null;
	}

	private static global::UnityEngine.Vector3 Ease(Interpolate.Function ease, global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 distance, float elapsedTime, float duration)
	{
		return default(global::UnityEngine.Vector3);
	}

	public static Interpolate.Function Ease(Interpolate.EaseType type)
	{
		return null;
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewBezier(Interpolate.Function ease, global::UnityEngine.Transform[] nodes, float duration)
	{
		return null;
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewBezier(Interpolate.Function ease, global::UnityEngine.Transform[] nodes, int slices)
	{
		return null;
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewBezier(Interpolate.Function ease, global::UnityEngine.Vector3[] points, float duration)
	{
		return null;
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewBezier(Interpolate.Function ease, global::UnityEngine.Vector3[] points, int slices)
	{
		return null;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Interpolate._003CNewBezier_003Ed__16<>))]
	private static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewBezier<T>(Interpolate.Function ease, global::System.Collections.IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, global::System.Collections.Generic.IEnumerable<float> steps)
	{
		return null;
	}

	private static global::UnityEngine.Vector3 Bezier(Interpolate.Function ease, global::UnityEngine.Vector3[] points, float elapsedTime, float duration)
	{
		return default(global::UnityEngine.Vector3);
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewCatmullRom(global::UnityEngine.Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewCatmullRom(global::UnityEngine.Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Interpolate._003CNewCatmullRom_003Ed__20<>))]
	private static global::System.Collections.Generic.IEnumerable<global::UnityEngine.Vector3> NewCatmullRom<T>(global::System.Collections.IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	private static global::UnityEngine.Vector3 CatmullRom(global::UnityEngine.Vector3 previous, global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Vector3 next, float elapsedTime, float duration)
	{
		return default(global::UnityEngine.Vector3);
	}

	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}
}
