 // put this script in your Loading screen when it start it will load the next screen using the number of playerpref in the scene array 
 // so you only need to put AsyncHelp in each scene and call the load function with thw number of the scene (position in the array ) you want to load.
//It will save this number, load your Loading Scene and then Asynload script will use the number to find and load the final scene. All async amd fast :)


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
       
        selector = PlayerPrefs.GetInt("Escena");
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
    
