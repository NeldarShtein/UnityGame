using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AbRest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Maze3DA", LoadSceneMode.Single);
    }
}
