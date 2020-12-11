using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msg_hide : MonoBehaviour
{

    void OnEnable()
    {
        StartCoroutine("HideMsg");   
    }

    IEnumerator HideMsg(){
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }

}
