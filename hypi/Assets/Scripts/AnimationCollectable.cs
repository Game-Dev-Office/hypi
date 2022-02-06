using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCollectable : MonoBehaviour
{
    public static float currentLength;
    public float animationSpeed = 1f;
    public float nLength;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationManager.instance.clipName == "Dancing Twerk")
        {
            currentLength = AnimationManager.instance.clipCurrentLength;
        }
        else if (AnimationManager.instance.clipName == "Stumbled")
        {
            nLength = AnimationManager.instance.clipCurrentLength;
            if (nLength > 0.8)
            {
                AnimationManager.instance.clipCurrentLength = currentLength;
                AnimationManager.instance.model.Play("Dancing Twerk", 0, currentLength);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AnimationManager.instance.clipCurrentLength = currentLength;
        AnimationManager.instance.animValue += 2;
        AnimationManager.instance.model.Play("Dancing Twerk", 0, currentLength);
    }
}
