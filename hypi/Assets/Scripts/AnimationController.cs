using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator model;

    // Start is called before the first frame update
    void Start()
    {
        model.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        model.Play("Dancing Twerk");
        model.speed = 0;
    }
}
