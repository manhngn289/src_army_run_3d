using UnityEngine;

public class TutorialInLevelGO : MonoBehaviour, ICanCollision
{
	public TutorialID tutorialID;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private TutorialRecordData tutorialRecordData;

	public ColliderType ColliderType => default(ColliderType);

	public ColliderShape Shape => default(ColliderShape);

	public MonoBehaviour SelfBehaviour => null;

	public LayerMask SelfLayer => default(LayerMask);

	public LayerMask CollisionLayer => default(LayerMask);

	public Vector3 Position => default(Vector3);

	public Quaternion Rotation => default(Quaternion);

	public Vector3 CenterOffset => default(Vector3);

	public float SphereRadius => 0f;

	public Vector3 BoxSize => default(Vector3);

	public bool IsActionOnNotCollision => false;

	private void Start()
	{
	}

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	public void UnregisterCollision()
	{
	}

	public TutorialRecordData Record()
	{
		return null;
	}

	public void RecoverFromData(TutorialRecordData data)
	{
	}
}
