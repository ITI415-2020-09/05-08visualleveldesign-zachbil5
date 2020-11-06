using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject wall_1, wall_2, wall_3, wall_4, wall_5, wall_6;
    public AudioClip wallOpen, mainMusicClip, pickupClip;
    public AudioSource audioS, mainMusicSource;
    private GameObject[] walls, walls2;
    private MeshRenderer wallRenderer;
    private Rigidbody rigB;
    private int count;


    void Start()
    {
        walls = new GameObject[] { wall_1, wall_2, wall_3 };
        walls2 = new GameObject[] { wall_4, wall_5, wall_6 };
        rigB = GetComponent<Rigidbody>();
        count = 0;
        winTextObject.SetActive(false);

        SetCountText();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            audioS.PlayOneShot(pickupClip);
            if (count >= 28 && walls[0].activeSelf)
            {
                setWallsInactive(walls);
            }
            if(count >= 34)
            {
                winTextObject.SetActive(true);
            }
        }
        if(other.gameObject.CompareTag("Pickup 2"))
        {
            mainMusicSource.Stop();
            mainMusicSource.PlayOneShot(mainMusicClip);
            
            other.gameObject.SetActive(false);
            setWallsInactive(walls2);
        }
        
    }

    void setWallsInactive(GameObject[] walls)
    {
        foreach (GameObject i in walls)
        {
            i.SetActive(false);
        }
        audioS.PlayOneShot(wallOpen);
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        
    }
}
