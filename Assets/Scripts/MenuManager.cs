using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Panel;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Settings()
    {
        Panel.GetComponent<Animator>().SetTrigger("Pop");
    }

    public void OpenSite()
    {
        Application.OpenURL("https://assetspace.online");
    }
}
