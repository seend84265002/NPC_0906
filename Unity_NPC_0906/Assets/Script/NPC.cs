using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private void dialoguet(string nar)
    {
        print("對話內容:"+nar);
    }
    ///<summary>
    ///對話內容
    ///</summary>
    public bool openStore()
    {
        return true;
    }
    ///<summary>
    ///開啟商店
    ///</summary>

    public int BuyProps()
    {
        print("道具價錢預設為" + 100);
        return 0;
    }
    ///<summary>
    ///購買道具
    ///</summary>

    public void getmission(int a)
    {
       print("任務編號"+a);
    }
    ///<summary>
    ///取得任務
    ///</summary>
    private int renmission()
    {
        print("獲得任務道具數量預設為"+1);
        return 0;
    }
    ///<summary>
    ///任務更新
    ///</summary>

    private bool missioncomp(int a)
    {
        print("任務編號"+a+"完成");
        return false;
    }
    ///<summary>
    ///任務完成
    ///</summary>

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
