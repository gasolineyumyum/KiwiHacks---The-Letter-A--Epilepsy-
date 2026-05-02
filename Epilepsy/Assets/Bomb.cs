using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bombVisual;
    public GameObject explosionVisual;

    public float fuseTime = 1.5f;
    public Collider2D col;

    void Start()
    {
        bombVisual.SetActive(true);
        explosionVisual.SetActive(false);

        col.enabled = false;

        StartCoroutine(Explode());
    }

    System.Collections.IEnumerator Explode()
    {
        yield return new WaitForSeconds(fuseTime);

        bombVisual.SetActive(false);
        explosionVisual.SetActive(true);

        col.enabled = true;

        yield return new WaitForSeconds(0.3f);

        Destroy(gameObject);
    }
}