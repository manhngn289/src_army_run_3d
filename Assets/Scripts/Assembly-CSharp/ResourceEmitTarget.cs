using Coffee.UIExtensions;
using UnityEngine;

public class ResourceEmitTarget : MonoBehaviour
{
	public Transform target;

	[SerializeField]
	private float scaleUpTarget;

	[SerializeField]
	private float scaleDownTime;

	[SerializeField]
	private UIParticle scaleFX;

	public void ScaleTarget()
	{
	}
}
