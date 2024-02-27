using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private GameObject background;

    [SerializeField]
    private GameObject pipes;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("Background");

        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        background.transform.position += new Vector3(-velocity, 0, 0) * Time.deltaTime;

        if (background.transform.position.x < -6.7f)
        {
            background.transform.position = new Vector3(-1.2f, 0.68f, 0.05f);
        }

    }

    void Spawn()
    {
        Instantiate(pipes, pipes.transform.position, Quaternion.identity);
    }
}
