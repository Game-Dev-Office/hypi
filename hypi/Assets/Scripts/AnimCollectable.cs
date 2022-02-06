using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCollectable : MonoBehaviour
{
    public static float currentLength;
    public float animationSpeed = 1f;
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
        AnimController.instance.animValue += 3;
        Test.instance.model.Play("Dancing Twerk", 0, currentLength);
        //Test.instance.model.SetLayerWeight(0, 1f);
        currentLength += animationSpeed * Time.deltaTime;
    }
}
