using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowNJup : MonoBehaviour
{
    Vector3 offset = new Vector3(5,5,0);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Kaboom");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 5.0f);

        //Debug.Log(hit.transform);
        Debug.DrawRay(transform.position + offset, Vector2.up * 50.0f, Color.red);
    }

    IEnumerator Kaboom()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
