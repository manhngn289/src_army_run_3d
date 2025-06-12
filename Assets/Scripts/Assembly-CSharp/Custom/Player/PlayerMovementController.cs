using Aluta;
using DG.Tweening;
using Everest.CustomEditor;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
	[SerializeField]
	private PlayerManager playerManager;

	public MoveType moveType;

	public bool startMove;

	public bool canMoveForward;

	[SerializeField]
	private float xLimit;

	[SerializeField]
	[ReadOnly]
	private Vector3 movePos;

	[Header("FORWARD SETTING")]
	[SerializeField]
	private float speedHorizontal;

	[SerializeField]
	private float speedForwardDefault;

	public float speedForwardBuff;

	[Header("FREE SETTING")]
	[SerializeField]
	private float moveFreeSpeed;

	public bool moveAnim;

	[SerializeField]
	private float smoothTime;

	private Vector3 velocity;

	[ReadOnly]
	[Header("FREE MOVE LIMIT")]
	public Transform limitPosTr;

	[ReadOnly]
	public Vector3 limitSize;

	[ReadOnly]
	[SerializeField]
	private float limitXFree;

	[SerializeField]
	[ReadOnly]
	private float limitZFreeBehind;

	[SerializeField]
	[ReadOnly]
	private float limitZFreeFront;

	private Coroutine autoUpdateSpeedCor;

	[Header("AUTO UPDATE SPEED")]
	[ReadOnly]
	public float buffNoCombatValue;

	[ReadOnly]
	public float changeBuffNoCombatTime;

	[ReadOnly]
	public float buffInCombatValue;

	[ReadOnly]
	public float changeBuffInCombatTime;

	private Tweener changeSpeedTween;

	private bool previousCombatStatus;

	public float SpeedForwardDefault => 0f;

	[DisplayAsString]
	public float CurrentSpeedForward => 0f;

	public bool IsAutoUpdateSpeed => false;

	private void OnValidate()
	{
	}

	public void ResetMovement()
	{
	}

	public void SetLimitMovement(Transform limitPos, Vector3 limitSizeApplied)
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void ChangeMoveType(MoveType moveTypeApplied)
	{
	}

	public void UpdateSpeed(float speedBuffChange, float timeChangeBuff)
	{
	}

	public void AutoUpdateSpeed(float buffNoCombat, float changeNoCombatTime, float buffInCombat, float changeInCombatTime)
	{
	}
}
