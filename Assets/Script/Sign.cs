using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Sign : MonoBehaviour
{

    public GameObject text;
    public Text signText;
    public string signSentence;
    public bool isInRangeOfSign;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRangeOfSign){
            showSignDialog();
        }
    }

    private void showSignDialog(){
        if(Input.GetKey(KeyCode.Space)){
            text.SetActive(true);
            signText.text = signSentence;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        isInRangeOfSign = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        SingletonManager.Instance.playerMovement.currentState = PlayerState.walk;
        isInRangeOfSign = false;
        text.SetActive(false);
        signText.text = "";
    }
}
