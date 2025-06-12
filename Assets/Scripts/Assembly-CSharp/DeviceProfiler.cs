using Unity.Profiling;
using UnityEngine;

public class DeviceProfiler : MonoBehaviour
{
	private string statsText;

	private ProfilerRecorder systemMemoryRecorder;

	private ProfilerRecorder gcMemoryRecorder;

	private ProfilerRecorder mainThreadTimeRecorder;

	private ProfilerRecorder batchRecorder;

	private ProfilerRecorder setPassCallsRecorder;

	private ProfilerRecorder drawCallsRecorder;

	private ProfilerRecorder trisRecorder;

	private ProfilerRecorder verticesRecorder;

	private GUIStyle textStyle;

	[SerializeField]
	private bool lockFps;

	private static double GetRecorderFrameAverage(ProfilerRecorder recorder)
	{
		return 0.0;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}
}
