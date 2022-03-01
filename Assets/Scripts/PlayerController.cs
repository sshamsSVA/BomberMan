using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Float for horizontal input variable
    float horizontalInput;
    // Float for vertical input variable
    float verticalInput;
    // // Float for movement speed
    float speed = 5;
    // Declaration of bomb prefab
    public GameObject bombPrefab;

    Quaternion lookDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal input axis
        horizontalInput = Input.GetAxis("Horizontal");
        // Get vertiacal input axis
        verticalInput = Input.GetAxis("Vertical");
        // Spawn in bomb when space is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBomb();
        }
        
        // lookDirection = Quaternion.LookRotation;
    }
    
    private void FixedUpdate() 
    {   
        // move character left, right, up and down based on horizontal and vertical input
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }

    // Method to instatiate the bomb prefab
    void SpawnBomb()
    {
        Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }
}
