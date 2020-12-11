using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rexcont : MonoBehaviour
{
    public GameObject fire;
    public GameObject win_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        fire.SetActive(true);
        StartCoroutine("santamantra");
    }

    IEnumerator santamantra(){
        yield return new WaitForSeconds(2);
        win_screen.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
