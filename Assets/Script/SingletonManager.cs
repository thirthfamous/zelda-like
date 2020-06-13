using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Sign sign;
    public static SingletonManager Instance { get; private set;} // static singleton
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null) { Instance = this; }
        else {Destroy(gameObject);}

        playerMovement = FindObjectOfType<PlayerMovement>();
        sign = FindObjectOfType<Sign>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
