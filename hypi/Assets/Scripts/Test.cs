using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Test : MonoBehaviour
{
    #region Singleton
    public static Test instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }
    #endregion

    
    public Animator model;
    public float animationSpeed = 1f;

    public float currentFrame;
    public float totalFrame;
    public float frameLength;
    public float clipTotalLength;
    public float clipCurrentLength;
    public string clipName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        AnimatorStateInfo stateInfos = model.GetCurrentAnimatorStateInfo(0);
        AnimatorClipInfo[] AnimationClip = model.GetCurrentAnimatorClipInfo(0);

        clipTotalLength = AnimationClip[0].clip.length;
        totalFrame = AnimationClip[0].clip.frameRate;
        clipCurrentLength = stateInfos.normalizedTime;
        clipName = AnimationClip[0].clip.name;

        //currentFrame = (stateInfos.normalizedTime * (AnimationClip[0].clip.length * AnimationClip[0].clip.frameRate));



        //Debug.Log(clipTotalLength);
        //Debug.Log(totalFrame);
        Debug.Log(clipName +" " +clipCurrentLength);

        /*
        AnimatorClipInfo[] AnimationClip = model.GetCurrentAnimatorClipInfo(0);
        totalFrame = AnimationClip[0].clip.length * AnimationClip[0].clip.frameRate;
        someValue = AnimationClip[0].weight;
        AnimatorStateInfo stateInfos = model.GetCurrentAnimatorStateInfo(0);
        progress = stateInfos.normalizedTime;

        Debug.Log(AnimationClip[0].clip.length);
        Debug.Log(AnimationClip[0].clip.frameRate);
        Debug.Log(progress);
        Debug.Log(someValue);
        */


    }

}
