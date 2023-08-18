using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadFromURL : MonoBehaviour
{
    [SerializeField] private private string url; //url to downloading file (google disk, etc...)
    private string result;
    
    IEnumerator Start()
    {
        WWW wwwV = new WWW(urlVersion);
        yield return wwwV;
        txtVer = wwwV.text; 
    }
}
