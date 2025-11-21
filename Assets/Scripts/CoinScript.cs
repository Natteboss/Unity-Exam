using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip pickupSound;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(pickupSound, other.transform.position);
            CoinManager.CoinsCollected += 0.5f;
            Destroy(gameObject);
        }
    }
}
