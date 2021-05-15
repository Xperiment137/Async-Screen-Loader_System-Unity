using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AsyLoader : MonoBehaviour
{

    private string Escena;
    private int selector;
    private string[] ArrayEscenas = new string[] { "Hospital", "CreacionPersonaje" ,"Cinematica1","Menu Principal", "Consciencia", "Casa","Pantano","Bahia","Pueblo"};


    private void Awake()
    {
       
        selector = PlayerPrefs.GetInt("Escena");
        Escena = ArrayEscenas[selector];
    }
    void Start()
    {
        LoadButton();
      
    }

    void LoadButton()
    {
        //Start loading the Scene asynchronously and output the progress bar
        StartCoroutine(LoadScene());
    }


   
        IEnumerator LoadScene()
        {
            yield return null;


            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Escena);



            yield return null;
        }
    }
    
