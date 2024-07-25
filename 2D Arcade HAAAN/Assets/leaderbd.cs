// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class leaderbd : MonoBehaviour
// {
//     public Transform row;
//     public GameObject ldbd_panel;
//     Transform row2;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
//     public void Leaderboard()
//     {
//         ldbd_panel.SetActive(true);
//         row2=Instantiate(row);
//         row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-3f);
//         row2.Find("");
//         row2.transform.position=row.transform.position;
        
//     }
// }



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class leaderbd : MonoBehaviour
// {
//     //Transform rowchild;
//     public Transform row,container;
//     public GameObject ldbd_panel;
//     //Transform row2;
//     // Start is called before the first frame update
//     // private void Awake()
//     // {
//     //     //container=transform.Find("Data");
//     //     //row=container.Find("ScoreEntry");
//     //     float templateHeight=20f;
//     //     //row.gameObject.SetActive(false);
//     //     for(int i=0;i<10;i++)
//     //     {
//     //         // Transform entryTransform=Instantiate(row,container);
//     //         // RectTransform entryRectTransform=entryTransform.GetComponent<RectTransform>();
//     //         // entryRectTransform.anchoredPosition=new Vector2(0,-templateHeight*i);
//     //         // entryTransform.gameObject.SetActive(true);
//     //         row2=Instantiate(row,container);
//     //         //row2.Find("Name_Text(TMP)").GetComponent<Text>().text="Aditya the god";
//     //         row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*2);
//     //     }
//     // }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
//     public void Leaderboard()
//     {
//         //float templateHeight=20f;
//         ldbd_panel.SetActive(true);
//         // row2=Instantiate(row,container);
//         // row2.Find("Name_Text(TMP)").GetComponent<Text>().text="Aditya the god";
//         // row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*2);
//         // row2.Find("Name_Text").GetComponent<Text>().text="Aditya the god";
//         //row2.transform.position=row.transform.position;
//         for(int i=0;i<5;i++)
//         {
           
//             Transform row2=Instantiate(row,container);
//             //row2.GetComponent<RectTransform>().anchoredPosition=new Vector2(0,-templateHeight*i);
//             //Transform rowchild=row2.GetChild(0);
//             //rowchild.GetComponent<Text>().text="Aditya the god";
//         }
        
//     }
// }


//--------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderbd : MonoBehaviour
{
    public Transform rowPrefab; // Prefab for a single row
    public Transform container; // Container where rows will be placed
    public GameObject ldbdPanel; // Panel to activate/deactivate
    public float rowHeight = 20f; // Height of each row

    void Start()
    {
        // Initially hide the leaderboard panel
        ldbdPanel.SetActive(false);
    }

    public void ShowLeaderboard(List<string> playerNames)
    {
        ldbdPanel.SetActive(true);

        // Clear existing rows
        foreach (Transform child in container)
        {
            Destroy(child.gameObject);
        }

        // Create rows for each player in the list
        for (int i = 0; i < playerNames.Count; i++)
        {
            // Instantiate a new row
            Transform row = Instantiate(rowPrefab, container);

            // Position the row
            RectTransform rowRectTransform = row.GetComponent<RectTransform>();
            rowRectTransform.anchoredPosition = new Vector2(0, -rowHeight * i);

            // Find the Text component and set the player name
            Text nameText = row.Find("Name_Text(TMP)").GetComponent<Text>();
            nameText.text = playerNames[i];
        }
    }
}
