using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCollectable : MonoBehaviour
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
        if (Test.instance.clipName == "Dancing Twerk")
        {
            currentLength = Test.instance.clipCurrentLength;
        }
        else if (Test.instance.clipName == "capoeira")
        {
            nLength = Test.instance.clipCurrentLength;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Test.instance.clipCurrentLength = currentLength;
        AnimController.instance.animValue += 2;
        Test.instance.model.Play("Dancing Twerk", 0, currentLength);
    }
}
