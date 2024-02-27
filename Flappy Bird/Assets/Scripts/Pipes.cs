using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField]
    private Control control;
    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.Find("Control").GetComponent<Control>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += new Vector3(-control.velocity, 0, 0) * Time.deltaTime;
        if (transform.position.x < -13f)
        {
            Destroy(gameObject);
        }
    }
}
