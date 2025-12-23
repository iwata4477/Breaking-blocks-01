public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.BlockDestroyed();
        Destroy(gameObject);
    }
}
