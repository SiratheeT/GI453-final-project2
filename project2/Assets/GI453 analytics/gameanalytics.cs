using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class gameanalytics : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Initialize();
    }

    private async void Initialize()
    {
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))

        {
            OnBuyItem("clickplaygame", 1);
        }
        if (Input.GetKeyDown(KeyCode.B))

        {
            OnBuyItem("countclickshoot", 1);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            OnBuyItem("countfinishgame", 1);
        }
    }


    private void OnBuyItem(string item, int count)
    {
        CustomEvent exampleEvent = new CustomEvent("gamegi453")
{
{"clickplaygame",item },
{"countclickshoot",item },
{"countfinishgame",item },
{"countTLB01",count },
{"countTLB02",count },
{"countTLB03",count },
    };
        AnalyticsService.Instance.RecordEvent(exampleEvent);
        Debug.Log($"Recording Event BuyPromotion {item},{count}");

    }

}
