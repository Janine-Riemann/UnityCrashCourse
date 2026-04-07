using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You did it!");
            Destroy(this.gameObject);
        }
    }
}
