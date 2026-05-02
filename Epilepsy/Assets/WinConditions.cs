using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditions : MonoBehaviour

{
    public int health2;
    public GameObject winPrefab;
    public GameObject losePrefab;

    void Start()
    {
     //health2 = transform.parent.Find("eyestage1").gameObject.GetComponent<FloatyFly>().health;  
    StartCoroutine(Switch());
 
    }

    System.Collections.IEnumerator Switch()
    {
        yield return new WaitForSeconds(90);

        // show sprite

        Instantiate(winPrefab, Vector3.zero, Quaternion.identity);

    }
}
