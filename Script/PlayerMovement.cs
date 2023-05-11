using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 1f;
    private Rigidbody2D rb;
    private string GROUND_TAG = "Ground";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddTorque(torqueAmount);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddTorque(-torqueAmount);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D trigger) {
        if(trigger.gameObject.CompareTag(GROUND_TAG)){
            Debug.Log("Hit");
            SceneManager.LoadScene(0);
        }
    }
}
