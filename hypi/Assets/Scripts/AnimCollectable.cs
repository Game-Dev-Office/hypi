using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCollectable : MonoBehaviour
{
    public Animator model;
    public AnimationClip twerkClip;
    public AnimatorClipInfo[] twerkClipInfo;
    public float newFrame;
    public float newFFrame;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //newFrame = Test.instance.currentFrame;
        AnimatorClipInfo[] twerkClip = model.GetCurrentAnimatorClipInfo(0);
        newFrame = (100f / (twerkClip[0].weight * (twerkClip[0].clip.length * twerkClip[0].clip.frameRate)));
        Debug.Log(newFrame);
    }

    private void OnTriggerEnter(Collider other)
    {
        AnimController.instance.animValue += 3;
        //model.Play("Dancing Twerk");
        model.Play("Dancing Twerk");
        
    }
}
