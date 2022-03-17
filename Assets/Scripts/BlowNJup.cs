using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class BlowNJup : MonoBehaviour
{
    RaycastHit2D hit;
    
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine("Kaboom");
        DetectBlocks db = GetComponent<DetectBlocks>();
       // db.CheckForBlocks();
        //db.OnDrawGizmos();
    }

    IEnumerator Kaboom()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
        Destroy(hit.collider.gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Linecast(transform.position, transform.position + new Vector3(0,1,0), 1 << LayerMask.NameToLayer("Action"));
 
        if (hit.collider != null)
        {
            StartCoroutine("Kaboom");  
            if (hit.collider.CompareTag("Blocks"))
            {
                Tile getTile(Tilemap tileMap, Vector3 pos) 
                { 
                    Vector3Int tilePos = tileMap.WorldToCell(pos);
                    var tile = Tilemap.GetTile<Tile>(pos);
 
                    return tile;
                }
            }
            else 
            {
                Debug.Log(hit.collider.gameObject);
            }
              
        }
            
    }
}
