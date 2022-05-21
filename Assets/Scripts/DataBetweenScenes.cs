using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBetweenScenes : MonoBehaviour
{
    public static DataBetweenScenes Instance;
    public string userName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
