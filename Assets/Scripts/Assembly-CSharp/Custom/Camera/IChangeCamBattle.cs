public interface IChangeCamBattle
{
	IChangeBattleCamActivePlayerAttackManager Manager { get; set; }

	void OnObjectDestroyed();
}
