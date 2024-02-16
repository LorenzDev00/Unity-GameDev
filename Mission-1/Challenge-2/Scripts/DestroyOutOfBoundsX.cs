public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -39.0f;
    private float bottomLimit = -1.0f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }

    }
}
