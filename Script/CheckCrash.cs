using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCrash : MonoBehaviour
{
    private string PLAYER_HEAD = "Head";
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag(PLAYER_HEAD)){
            Debug.Log("Dead");
        }
    }
}
