using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///NPC
///定義NPC方法
///</summary>
public class NPC : MonoBehaviour
{
    ///<summary>
    ///對話內容
    ///</summary>
    ///<param name="nar">NPC 要說的對話內容</param>
    private void dialogue(string nar)
    {
        
    }
    ///<summary>
    ///開啟商店
    ///</summary>

    public bool openStore()
    {
        return true;
    }
    ///<summary>
    ///購買道具
    ///</summary>
    ///<param name="price">道具價錢</param>
    public int BuyProps(int price=100)
    {       
        return 0;
    }

    ///<summary>
    ///取得任務
    ///</summary>
    ///<param name="Tasknumber">任務編號</param>
    public void getmission(int Tasknumber)
    {
       
    }
    ///<summary>
    ///任務更新
    ///</summary>
    ///<param name="Missionprops">任務道具數量</param>
    private int renmission(int Missionprops)
    {
        return 0;
    }

    ///<summary>
    ///任務完成
    ///</summary>
    ///<param name="Tasknumber">任務編號</param>
    private bool missioncomp(int Tasknumber)
    {
        return false;
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
