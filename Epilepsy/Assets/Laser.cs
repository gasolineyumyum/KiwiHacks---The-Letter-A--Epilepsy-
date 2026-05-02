using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject warningVisual;
    public GameObject laserVisual;

    public float warningTime = 1f;
    public Collider2D col;
    public float activeTime = 2f;
   void Start()
{
    warningVisual.SetActive(true);
    laserVisual.SetActive(false);

    col.enabled = false; 

    StartCoroutine(Switch());
}
System.Collections.IEnumerator Switch()
{
    yield return new WaitForSeconds(warningTime);

    warningVisual.SetActive(false);
    laserVisual.SetActive(true);

    yield return new WaitForSeconds(activeTime);

    Destroy(gameObject);
}
}