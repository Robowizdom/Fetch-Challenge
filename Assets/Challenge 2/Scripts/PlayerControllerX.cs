using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool send = true;
    void Start()
    {
        InvokeRepeating("Send", 0.5f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && send)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            send = false;
        }
    }

    void Send()
    {
        send = true;
    }
}
