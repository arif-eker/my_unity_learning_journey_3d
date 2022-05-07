using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// [RequireComponent(typeof(Rigidbody))] // Bu script bir objeye atanırsa, otomatik olarak belirtilen componentte eklenir.

public class hide_flags_8 : MonoBehaviour
{


    [HideInInspector] // age değişkenini inspector penceresinde görülemez yapar
    public string age;


    [Range(1, 5)] // incpector kısmında kaydırmalı şekilde ve belirtilen sınırlar içinde değer seçilebilir.
    public float clc;

    [Min(5)]// inspectorda değer 5'ten az yazılamaz.
    public int exp;

    [Multiline(2)] // 2 satır olacak şekilde gösterir
    public string description;


    [Tooltip("It's my description for this state")] // inspector da üzerinde imleci bekletince açıklama çıkacak.
    public bool isMale;


    [Header("Player info")]
    public int plyr_health;
    [Header("Enemy info")]
    public int enmy_health;


    [ContextMenu("Player Settings")] // scriptin yanındaki 3 noktaya tıkladığında en altta bu isimde seçenek çıkar. Tıklayınca fonksiyon çalışacak.
    void PlayerSetting() { print("Player settings area"); }



    void Start()
    {

        //gameObject.hideFlags = HideFlags.HideInHierarchy; // hiyerarşi pencersinde görünmez yapar
        //gameObject.hideFlags = HideFlags.HideInInspector; // inspector penceresindeki componentleri görünmez yapar
        //gameObject.hideFlags = HideFlags.NotEditable; // inspector penceresindeki componentleri editlenemez yapar

        
    }





}
