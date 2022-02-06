using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class AnimationManager : MonoBehaviour
{
    #region Singleton
    public static AnimationManager instance;

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
    public float animValue;

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
        AnimationValue();

        AnimatorStateInfo stateInfos = model.GetCurrentAnimatorStateInfo(0);
        AnimatorClipInfo[] AnimationClip = model.GetCurrentAnimatorClipInfo(0);

        clipTotalLength = AnimationClip[0].clip.length;
        totalFrame = AnimationClip[0].clip.frameRate;
        clipCurrentLength = stateInfos.normalizedTime;
        clipName = AnimationClip[0].clip.name;

        Debug.Log(clipName +" "+ clipCurrentLength);
    }

    public void AnimationValue()
    {
        if (animValue > 0)
        {
            animValue -= 1 * Time.deltaTime;
            model.speed = 1;
        }
        else if (animValue <= 0)
        {
            animValue = 0;
            model.speed = 0;
        }
    }

}
