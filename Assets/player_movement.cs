using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_movement : MonoBehaviour
{ [SerializeField] float PlayerSpeed;
  [SerializeField] float maxSpeed;
    private int PlayerDirection;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        PlayerDirection = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDirection = 0;
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            PlayerDirection = 1; 
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerDirection = -1;
        }
        rigidBody.AddForce(Vector3.right * PlayerSpeed * PlayerDirection);
     if (rigidBody.velocity.sqrMagnitude > maxSpeed * maxSpeed)
        {
            Vector3 norm = rigidBody.velocity.normalized;
            rigidBody.velocity = new Vector3(norm.x * maxSpeed, norm.y * maxSpeed, norm.z * maxSpeed);
        }
    }
}
