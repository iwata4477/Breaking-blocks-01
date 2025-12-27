using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int blockCount;

    void Awake()
    {
        Instance = this;
    }
   public void RegisterBlock()
{
    blockCount++;
}
    public void BlockDestroyed()
    {
        blockCount--;
        if (blockCount <= 0)
        {
            Clear();
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
    }

    void Clear()
    {
        Debug.Log("CLEAR!");
    }
}
