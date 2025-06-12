using System.Collections.Generic;
using Aluta;
using DG.Tweening;
using Everest.CustomEditor;
using UnityEngine;

public class TrapBigGuy : TrapDestroyable, IObjectCanRecord
{
	private const string FLASH_NAME = "_FlashIntensity1";

	private const string RUN = "Run";

	private const string IDLE = "Idle";

	private const string ATTACK = "Attack";

	private const string TAUNT = "Taunt";

	public bool canMove;

	[SerializeField]
	private Renderer renderer;

	[SerializeField]
	private float brightValue;

	private Tweener takeDmgEffect;

	public TrapCheckPlayer trapCheckPlayer;

	[SerializeField]
	private Animator animator;

	[ReadOnly]
	[SerializeField]
	private bool startMove;

	public float speed;

	[SerializeField]
	private float dealDmgRadius;

	[SerializeField]
	private Vector3 dealDmgOffset;

	[SerializeField]
	private float checkPlayerToAttackRadius;

	[SerializeField]
	private float checkPlayerToTauntRadius;

	private Collider[] targets;

	[SerializeField]
	private Transform ragdollUnit;

	[SerializeField]
	private KillAllyType killAllyType;

	private Transform playerManagerTr;

	private bool isAttack;

	private bool isTaunt;

	private bool previousStartMove;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public TrapBigGuyRecordDataSO trapBigGuyRecordDataSo;

	public override void Init()
	{
	}

	public void Idle()
	{
	}

	public void Run()
	{
	}

	protected override void TakeDmgAnim()
	{
	}

	private void SetMatValue(string valueName, float value)
	{
	}

	public void ActiveMove()
	{
	}

	[Button(null)]
	private void TakeDmgEffect()
	{
	}

	public void BackToPreviousState()
	{
	}

	public void Taunt()
	{
	}

	private void Attack()
	{
	}

	private void Update()
	{
	}

	public void KillAllTroopInRadius()
	{
	}

	private void DealDmgAll(List<ICanCollision> collisions)
	{
	}

	private void EnableRagdoll()
	{
	}

	protected override void OnTrapDestroyed()
	{
	}

	public IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public void RecoverFromDataFallback()
	{
	}

	protected override void OnDrawGizmosSelected()
	{
	}
}
