using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private Animator anim;
    public int healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy(){
        if(ShouldTheObjectDestroyed()){
            anim.SetBool("smashed", true);
            StartCoroutine(destroyCo());
        }
    }

    private bool ShouldTheObjectDestroyed(){
        healthPoint -= 1;
        return healthPoint == 0; // return if object should be destroyed
    }

    IEnumerator destroyCo(){
        yield return new WaitForSeconds(.3f);
        Destroy(gameObject);
    }
}
