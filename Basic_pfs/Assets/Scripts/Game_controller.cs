using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_controller : MonoBehaviour
{
    public GameObject win_screen;
    public GameObject target_container;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        if (target_container.transform.childCount < 1){
            win_screen.SetActive(true);
            StartCoroutine("WinGame");
        }

        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }

    IEnumerator WinGame(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
