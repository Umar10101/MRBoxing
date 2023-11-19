using UnityEngine;

public class PunchImpactFX : MonoBehaviour
{
    public GameObject punchEffectPrefab; // Reference to the particle system prefab

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("enemy"))
        {
            Debug.Log("Punched the enemy");

            // Instantiate the particle effect prefab at the glove's position
            GameObject effectInstance = Instantiate(punchEffectPrefab, transform.position, Quaternion.identity);

            // Get the ParticleSystem component from the instantiated prefab
            ParticleSystem particleSystem = effectInstance.GetComponent<ParticleSystem>();

            // Play the particle effect
            if (particleSystem != null)
            {
                particleSystem.Play();
            }

            // Destroy the instantiated effect after its duration
            Destroy(effectInstance, particleSystem.main.duration);
        }
    }
}
