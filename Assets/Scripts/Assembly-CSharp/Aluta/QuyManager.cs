using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Aluta
{
	public static class QuyManager
	{
		[CompilerGenerated]
		private sealed class _003CCheckInternetConnection_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int timeout;

			public Action<bool> action;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003CCheckInternetConnection_003Ed__81(int _003C_003E1__state)
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

		private static readonly string[] suffixes;

		public static void Alpha(this Graphic graphicTarget, float value)
		{
		}

		public static void Alpha(this SpriteRenderer renderer, float value)
		{
		}

		public static void ChangeGraphicAlpha(this CanvasGroup canvasGroup, float value)
		{
		}

		public static void ChangeAlphaMultiObject(this Graphic[] targets, float value)
		{
		}

		public static void ChangeAlphaMultiObject(this CanvasGroup[] targets, float value)
		{
		}

		public static void Alpha(this IEnumerable<SpriteRenderer> targets, float value)
		{
		}

		public static void ChangeImgsAlpha(this Image[] targetImgs, float value)
		{
		}

		public static void Log(string log, Colorize colorize = null)
		{
		}

		public static void Log(this GameObject thisGameObjectCall, string log, Colorize colorize = null)
		{
		}

		public static void Log(this GameObject thisGameObjectCall, string log, int nameLimit, Colorize colorize = null)
		{
		}

		public static void Active(this IEnumerable<Component> gameObjects)
		{
		}

		public static void Active(this IEnumerable<GameObject> gameObjects)
		{
		}

		public static void Active(this GameObject targetObject)
		{
		}

		public static void Active(this Component targetObject)
		{
		}

		public static void Enable(this MonoBehaviour behaviour, bool isEnable)
		{
		}

		public static void Enable(this IEnumerable<MonoBehaviour> behaviours, bool isEnable)
		{
		}

		public static void Deactive(this GameObject targetObject)
		{
		}

		public static void Deactive(this Component targetObject)
		{
		}

		public static void Deactive(this IEnumerable<GameObject> gameObjects)
		{
		}

		public static void Deactive(this IEnumerable<Component> gameObjects)
		{
		}

		public static List<Transform> GetAllChild(this Transform parent)
		{
			return null;
		}

		public static void DetachAllChild(this IEnumerable<Transform> childs)
		{
		}

		public static void DetachAllChild(this IEnumerable<MonoBehaviour> childs)
		{
		}

		public static void DetachAllChild(this IEnumerable<GameObject> childs)
		{
		}

		public static void SetParentAllChild(this List<GameObject> childs, Transform parent)
		{
		}

		public static void SetParentAllChild(this IEnumerable<Transform> childs, Transform parent)
		{
		}

		public static void SetParentAllChild(this IEnumerable<MonoBehaviour> childs, Transform parent)
		{
		}

		public static void DeactiveAllChildren(this GameObject parent)
		{
		}

		public static void DeactiveAllChildren(this Transform parent)
		{
		}

		public static List<Vector3> GetAllLocalPos(this IEnumerable<Transform> childs)
		{
			return null;
		}

		public static List<Vector3> GetAllLocalPos(this IEnumerable<MonoBehaviour> childs)
		{
			return null;
		}

		public static List<Vector3> GetAllLocalPos(this IEnumerable<GameObject> childs)
		{
			return null;
		}

		public static void ChangeMultiImgSprite(this Image[] imagesChangeSprite, Sprite spriteChangeto)
		{
		}

		public static void TurnOffMultiObject(this IEnumerable<GameObject> gameObjects)
		{
		}

		public static void PlayMultiParticle(this IEnumerable<ParticleSystem> particleSystems)
		{
		}

		public static void OffMultiParticle(this IEnumerable<ParticleSystem> particleSystems)
		{
		}

		public static Canvas GetCanvas(this RectTransform rt)
		{
			return null;
		}

		public static float GetWidth(this RectTransform rt)
		{
			return 0f;
		}

		public static float GetHeight(this RectTransform rt)
		{
			return 0f;
		}

		public static Vector3 GetV3(this Vector3 targetVector, float x, float y, float z)
		{
			return default(Vector3);
		}

		public static bool IsInRect(this Vector3 center, Vector3 pointCheck, Vector2 size)
		{
			return false;
		}

		public static bool IsInRect(this Vector3 center, Vector3 pointCheck, Vector3 size, Vector3 offSetCenter)
		{
			return false;
		}

		public static Vector2 RandomPositionInRectangle(Vector2 rectangleSize, Vector3 center)
		{
			return default(Vector2);
		}

		public static Vector3 RandomPositionInRectangle(Vector3 rectangleSize, Vector3 center)
		{
			return default(Vector3);
		}

		public static Vector3 RandomPositionInCube(Vector3 cubeSize, Vector3 center)
		{
			return default(Vector3);
		}

		public static Vector2 RandomPositionInRectangle(Vector2 rectangleSize, Vector3 center, Rect exceptRect)
		{
			return default(Vector2);
		}

		public static bool IsNumber(this string input, out double number)
		{
			number = default(double);
			return false;
		}

		public static bool IsInCircle(Vector2 center, float radius, params Vector2[] pointChecks)
		{
			return false;
		}

		public static bool LineIntersectsRect(Vector2 p1, Vector2 p2, Rect r, Vector2 rectCenter)
		{
			return false;
		}

		public static bool LineIntersectsLine(Vector2 l1p1, Vector2 l1p2, Vector2 l2p1, Vector2 l2p2)
		{
			return false;
		}

		public static List<Vector3> TransformToPosition3(params Transform[] transforms)
		{
			return null;
		}

		public static List<Vector2> TransformToPosition2(params Transform[] transforms)
		{
			return null;
		}

		public static Vector2Int ToV2Int(this Vector2 vector2)
		{
			return default(Vector2Int);
		}

		public static int Pow(this int bas, int exp)
		{
			return 0;
		}

		public static Vector3 GetMouseWorldPos()
		{
			return default(Vector3);
		}

		public static int[][] ConvertTo2DArray(this string inputString)
		{
			return null;
		}

		public static bool IsPointerOverUIObject()
		{
			return false;
		}

		public static int[] ConvertEnumArrayToIntArray(this object[] enumArray)
		{
			return null;
		}

		private static int ConvertEnumToInt(object enumValue)
		{
			return 0;
		}

		public static Vector3 Rotate(this Vector3 originalVecter, float angle, Vector3 direction)
		{
			return default(Vector3);
		}

		public static Vector3 Circle(Vector3 center, float angle, float defaultRadius)
		{
			return default(Vector3);
		}

		public static Vector3 GetRandomDirXY()
		{
			return default(Vector3);
		}

		public static bool IsPointInRotatedRectangle(Vector3 pointCheck, Vector3 rectCenter, Vector2 rectSize, Quaternion rectRotation, Vector3 offset)
		{
			return false;
		}

		private static Vector3 RotatePointToLocalSpace(Vector3 point, Vector3 rectCenter, Quaternion rectRotation)
		{
			return default(Vector3);
		}

		public static Vector3 CalculateReflectionVector(Vector3 originalVector, int axis = 0)
		{
			return default(Vector3);
		}

		public static string ColorChange(this string text, Color color)
		{
			return null;
		}

		public static Vector3 Interpolate(Vector3 start, Vector3 end, Vector3 tanPoint1, Vector3 tanPoint2, float t)
		{
			return default(Vector3);
		}

		public static Vector3 Interpolate(Vector3 start, Vector3 end, Vector3 tanPoint1, Vector3 tanPoint2, float t, out Vector3 tangent)
		{
			tangent = default(Vector3);
			return default(Vector3);
		}

		public static Vector3 Interpolate(Vector3 start, Vector3 end, Vector3 tanPoint1, Vector3 tanPoint2, float t, out Vector3 tangent, out Vector3 curvature)
		{
			tangent = default(Vector3);
			curvature = default(Vector3);
			return default(Vector3);
		}

		public static bool IsSceneViewCameraInRange(Vector3 position, float distance)
		{
			return false;
		}

		public static Vector3[] CreateSplineCatmullRom(List<Vector3> spawnPath, int pathResolution)
		{
			return null;
		}

		public static bool LineSegmentsIntersect(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, out Vector2 intersection)
		{
			intersection = default(Vector2);
			return false;
		}

		private static bool IsPointOnLineSegment(Vector2 point, Vector2 start, Vector2 end)
		{
			return false;
		}

		public static string TimeToString(this TimeSpan duration)
		{
			return null;
		}

		public static float NormalizeEuler(this Transform transform)
		{
			return 0f;
		}

		public static List<int> RandomUniqueSequence(int min, int max, int n)
		{
			return null;
		}

		public static string ShortenNumber(this float n)
		{
			return null;
		}

		public static string ShortenNumber(this int n)
		{
			return null;
		}

		public static bool GetBool(string key, bool defaultValue = true)
		{
			return false;
		}

		public static void SetBool(string key, bool value)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckInternetConnection_003Ed__81))]
		public static IEnumerator CheckInternetConnection(Action<bool> action, int timeout = 1)
		{
			return null;
		}

		public static bool CheckDeviceInternetConnection()
		{
			return false;
		}
	}
}
