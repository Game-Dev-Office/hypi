using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animation twerk;
    public GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameObject>().GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        twerk["Dancing Twerk"].time = 5.0f;
    }
}
