using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBlock : MonoBehaviour
{
    public Animator blockModel;
    public float nextL;
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
        AnimCollectable.currentLength = Test.instance.clipCurrentLength;
        AnimController.instance.animValue += 1;
        blockModel.Play("capoeira");
    }

}
