using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AsyLoader : MonoBehaviour
{

    private string Escena;
    private int selector;
    private string[] ArrayEscenas = new string[] { "Main Menu", "Scene 1" , "Scene 2"}; // name of your scenes


    private void Awake()
    {
       
        selector = PlayerPrefs.GetInt("Escena"); // put this script in your Loading screen when it start it will load the next screen using the number of playerpref in the scene array 
        Escena = ArrayEscenas[selector];
    }
    void Start()
    {
        LoadButton();
      
    }

    void LoadButton()
    {
        //Start loading the Scene asynchronously
        StartCoroutine(LoadScene());
    }


   
        IEnumerator LoadScene()
        {
            yield return null;


            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Escena);



            yield return null;
        }
    }
    
