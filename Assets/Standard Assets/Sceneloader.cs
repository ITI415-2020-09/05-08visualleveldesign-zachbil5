using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadTerrain()
    {
        SceneManager.LoadScene("scene_1");
    }

    // Update is called once per frame
    public void LoadSnaps()
    {
        SceneManager.LoadScene("scene_2");
    }

    public void LoadPrototype2()
    {
        SceneManager.LoadScene("Prototype_2");
    }
}
