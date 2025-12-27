using UnityEngine;
public class Paddle : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float input =
            Input.GetAxis("Horizontal"); // ← → & A D 両対応

        transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }
}
