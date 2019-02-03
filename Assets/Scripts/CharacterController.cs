using turn;

public interface ICharacterController
{
    void TakeDamage(int damage);

    void DealDamage(int damage, TurnChecker.Turn turn);
}
