using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private string PLAYER_HEAD = "Head";
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag(PLAYER_HEAD)){
            Debug.Log("Goal");
            SceneManager.LoadScene(0);
        }
    }
}
