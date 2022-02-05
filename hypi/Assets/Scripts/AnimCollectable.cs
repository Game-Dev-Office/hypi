using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCollectable : MonoBehaviour
{
    public Animator model;
    public AnimationClip twerkClip;
    public float newLength;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        AnimController.instance.animValue += 1;
        //model.Play("Dancing Twerk");
        model.Play("Dancing Twerk", 0, 0.1f);
        
    }
}
