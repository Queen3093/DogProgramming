using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float slowDog = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && slowDog <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            slowDog = 1;
        }

        if (slowDog >= 0)
        {
            slowDog -= Time.deltaTime;
        }
    }
}
