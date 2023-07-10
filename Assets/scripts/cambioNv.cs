using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioNv : MonoBehaviour
{
    public void nivel( string Nv)
    {
        SceneManager.LoadScene(Nv);
    }
    
}
