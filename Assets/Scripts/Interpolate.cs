using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

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

	public delegate Vector3 ToVector3<T>(T v);

	public delegate float Function(float a, float b, float c, float d);

	[CompilerGenerated]
	private sealed class _003CNewBezier_003Ed__16<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IList nodes;

		public IList _003C_003E3__nodes;

		private IEnumerable<float> steps;

		public IEnumerable<float> _003C_003E3__steps;

		private ToVector3<T> toVector3;

		public ToVector3<T> _003C_003E3__toVector3;

		private Function ease;

		public Function _003C_003E3__ease;

		private float maxStep;

		public float _003C_003E3__maxStep;

		private Vector3[] _003Cpoints_003E5__2;

		private IEnumerator<float> _003C_003E7__wrap2;

		Vector3 IEnumerator<Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNewBezier_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CNewCatmullRom_003Ed__20<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IList nodes;

		public IList _003C_003E3__nodes;

		private ToVector3<T> toVector3;

		public ToVector3<T> _003C_003E3__toVector3;

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

		Vector3 IEnumerator<Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNewCatmullRom_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CNewCounter_003Ed__6 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
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

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNewCounter_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CNewEase_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector3 end;

		public Vector3 start;

		public IEnumerable<float> driver;

		public Function ease;

		public float total;

		private Vector3 _003Cdistance_003E5__2;

		private IEnumerator<float> _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNewEase_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CNewTimer_003Ed__3 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private float duration;

		public float _003C_003E3__duration;

		private float _003CelapsedTime_003E5__2;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNewTimer_003Ed__3(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CNewTimer_003Ed__3))]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNewCounter_003Ed__6))]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNewEase_003Ed__9))]
	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	public static Function Ease(EaseType type)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNewBezier_003Ed__16<>))]
	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CNewCatmullRom_003Ed__20<>))]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
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
