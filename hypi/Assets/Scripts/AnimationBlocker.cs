using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBlocker : MonoBehaviour
{
    public Animator blockModel;
    public float nextL;
    public float state;
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
        AnimationCollectable.currentLength = AnimationManager.instance.clipCurrentLength;
        AnimationManager.instance.animValue += 1;
        blockModel.Play("Stumbled");
    }

}
