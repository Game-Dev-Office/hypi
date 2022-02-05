using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBlock : MonoBehaviour
{
    public Animator blockModel;
    public AnimationClip blockModelClip;
    public float frame;
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
        
        blockModel.Play("capoeira");
    }
}
