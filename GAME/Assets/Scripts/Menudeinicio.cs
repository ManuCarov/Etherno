using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Menudeinicio : MonoBehaviour
{
 public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Salir(){
        Debug.Log("Salir...");
        Application.Quit();

    }
}
