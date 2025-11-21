using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip pickupSound;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
            CoinManager.CoinsCollected += 1f;
        }
    }
}
