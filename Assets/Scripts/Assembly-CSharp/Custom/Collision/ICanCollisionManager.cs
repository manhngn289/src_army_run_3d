public interface ICanCollisionManager
{
	void RegisterCollisionObject(ICanCollision collisionObject);

	void UnregisterCollisionObject(ICanCollision collisionObject);
}
