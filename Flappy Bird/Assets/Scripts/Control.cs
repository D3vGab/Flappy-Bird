using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private GameObject background;
    public float velocity;

    [SerializeField]
    private GameObject pipes;
    public GameObject gameOver;

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

    // Spawn new pipes
    void Spawn()
    {
        Instantiate(pipes, pipes.transform.position, Quaternion.identity);
    }
    
    // If player lose then...
    void GameOver()
    {
        gameOver.SetActive(true);
    }

    // Reload Scene
    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
