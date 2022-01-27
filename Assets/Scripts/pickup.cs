using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class pickup : MonoBehaviour
{
    private bool pickupActive = true;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (pickupActive == true)
        {
            Debug.Log("Trigger Worked");
            pickupActive = false;
            timePassed = Time.time;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        if (pickupActive == false)
        {
            float timeElapsed = Time.time - timePassed;
            if (timeElapsed >= 3.0f)
            {
                Debug.Log("Respawn Worked");
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                pickupActive = true;
            }
        }
    }
}
