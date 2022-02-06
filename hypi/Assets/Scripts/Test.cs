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
    public float currentFrame;
    public Animator model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AnimatorClipInfo[] AnimationClip = model.GetCurrentAnimatorClipInfo(0);
        currentFrame = (100f / (AnimationClip[0].weight * (AnimationClip[0].clip.length * AnimationClip[0].clip.frameRate)));
        Debug.Log(currentFrame);

    }

}
