using UnityEngine;

[CreateAssetMenu(fileName = "ButtonAnimationSetting", menuName = "ScriptableObjects/Quy/ButtonAnimationSetting")]
public class ButtonAnimationSetting : ScriptableObject
{
	public float scalePress;

	public float timeScalePress;

	public float timeScaleRelease;

	public AnimationCurve buttonReleaseCurve;
}
