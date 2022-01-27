using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    public CharacterController player;
    public GameObject respawnPoint;
    //public GameObject playerCharacter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Player Resetting");
            Debug.Log(respawnPoint.transform.position);
            Vector3 deltaMovement = respawnPoint.transform.position - player.transform.position;
            player.detectCollisions = false;
            //player.enabled = false;
            player.Move(deltaMovement); //diable collision then renable afterwards
            //player.enabled = true;
            player.detectCollisions = true;
        }
        
    }
}
