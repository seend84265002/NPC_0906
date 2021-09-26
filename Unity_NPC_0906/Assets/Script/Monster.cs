using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{
    [Header("移動速度，攻擊力，血量，位移"),Range(0,10)]
    public float speed=3.5f;
    [Range(0, 500)]
    public int attack = 100;
    [Range(0, 5000)]
    public int hp = 350;
    [Range(0,50)]
    public float range =30f;
    public Vector3 v3Trackdisplacement;
    
    [Header("道具掉落及機率")]
    public GameObject Props;
    [Range(0, 1)]
    public float ProbabilityofProps;

    [Header("音效設定")]
    public AudioClip AudioProps;
    public AudioClip AudioHurt;
    public AudioClip Audioattack;

    public AudioSource audios;
    public Rigidbody2D rdbody2D;
    public Animation anima;

    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
}
