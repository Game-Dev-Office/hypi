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

    public float totalFrame;
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

        Debug.Log(clipName +" "+ clipCurrentLength);
    }

}
