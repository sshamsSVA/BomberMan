using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowNJup : MonoBehaviour
{
    

    public float distance;

    [SerializeField] Transform castPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Kaboom");
        StartCoroutine("DetectBlocks");
    }

    // Update is called once per frame
    void Update()
    {
        

    
    }

    IEnumerator Kaboom()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    IEnumerator DetectBlocks()
    {
        yield return null;
    }
}
