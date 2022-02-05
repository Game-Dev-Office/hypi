using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    #region Singleton
    public static AnimController instance;

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
    public Animation mModel;
    public float animValue;
    public AnimatorStateInfo m_CurrentStateInfo;
    public float length;

    // Start is called before the first frame update
    void Start()
    {
        model.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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

        length = model.GetCurrentAnimatorStateInfo(0).length;
    }

    private void OnTriggerEnter(Collider other)
    {
        model.Play("Dancing Twerk");
        model.speed = 0;
        
    }
}
