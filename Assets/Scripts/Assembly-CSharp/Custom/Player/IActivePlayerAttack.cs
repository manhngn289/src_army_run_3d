public interface IActivePlayerAttack
{
	IChangeBattleCamActivePlayerAttackManager Manager { get; set; }

	void OnObjectDestroyed();
}
