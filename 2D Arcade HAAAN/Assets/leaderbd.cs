using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderbd : MonoBehaviour
{
    public Transform row;
    public GameObject ldbd_panel;
    Transform row2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Leaderboard()
    {
        ldbd_panel.SetActive(true);
        row2=Instantiate(row);
        row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-3f);
        row2.Find("");
        row2.transform.position=row.transform.position;
        
    }
}
