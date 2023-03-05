using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Button_Hero : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Button Hero1_button;

    [SerializeField]
    Button Hero2_button;

    [SerializeField]
    Button Hero3_button;

    [SerializeField]
    GameObject prefabCircle;

    [SerializeField]
    GameObject tower;


    private void Awake()
    {
        Time.timeScale = 0;
        //Hero1_button.interactable = false;
    }
    public void playGame()
    {
        //Hero1_button.interactable = false;
        //Hero2_button.interactable = false;
        //Hero3_button.interactable = true;
        Time.timeScale = 1;
        Debug.Log("click");
       
    }
    public void spawnBall(Vector3 position)
    {
        GameObject ball = Instantiate(prefabCircle);
        ball.transform.position = position;
        
    }
    public void hero1()
    {

        float x = tower.transform.position.x + 6;
        float y = tower.transform.position.y - 2;
        float z = tower.transform.position.z + 2;
        Vector3 pos = new Vector3(x, y, z);
        spawnBall(pos);
        Debug.Log("new hero 1");
     
    }
    public void hero2()
    {
        float x = tower.transform.position.x +8;
        float y = tower.transform.position.y - 2;
        float z = tower.transform.position.z + 1;
        Vector3 pos = new Vector3(x, y,z);
        spawnBall(pos);
        Debug.Log("new hero 2");
     
    }
    public void hero3()
    {
        float x = tower.transform.position.x + 10;
        float y = tower.transform.position.y -2;
        float z = tower.transform.position.z;
        Vector3 pos = new Vector3(x, y, z);
        spawnBall(pos);
        Debug.Log("new hero3");
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
