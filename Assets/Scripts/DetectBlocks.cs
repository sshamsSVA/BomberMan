using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBlocks : MonoBehaviour
{
    // public float raycastRadius;  // width of our line of sight (x-axis and y-axis)
    // public float detectDistance;  // depth of our line of sight (z-axis)

    // private RaycastHit raycastHitInfo;   // allocating memory for the raycasthit
    // // to avoid Garbage
    // private bool racastDetectedBlocks = false;   // tracking whether the player
    // // is detected to change color in gizmos

    // public void CheckForBlocks()
    // {
    //     racastDetectedBlocks = Physics.SphereCast(transform.position, raycastRadius, transform.up, out raycastHitInfo, detectDistance);

    //     if (racastDetectedBlocks)
    //     {
    //         if (raycastHitInfo.transform.CompareTag("Player"))
    //         {
    //             Debug.Log("Detected Player");
    //             // insert fighting logic here
    //         } else if (raycastHitInfo.transform.CompareTag("Blocks")) {
    //             Debug.Log("Detected Blocks");
    //         }
    //         else
    //         {
    //             Debug.Log("No Player detected");
    //             // no player detected, insert your own logic
    //         }

    //     } else
    //     {
    //         // no player detected, insert your own logic
    //     }
    // }
    // public void OnDrawGizmos()
    // {
    //     if (racastDetectedBlocks)
    //     {
    //         Gizmos.color = Color.red;
    //     } else
    //     {
    //         Gizmos.color = Color.green;
    //     }

    //     Gizmos.matrix = transform.localToWorldMatrix;

    //     Gizmos.DrawCube(new Vector3(0f, 0f, detectDistance / 2f), new Vector3(raycastRadius, raycastRadius, detectDistance));
    // }
}
