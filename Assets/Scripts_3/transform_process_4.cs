using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform_process_4 : MonoBehaviour
{

    //Vector2 xy;
    //Vector3 xyz;

    //Vector3 position_1;
    //Vector3 position_2;

    // static methods
    //public Transform a;
    //public Transform b;

    //public Transform parent;
    //public GameObject child;



    private float start_time;
    void Start()
    {

        //Debug.Log(transform.position);
        //Debug.Log(transform.rotation);
        //Debug.Log(transform.localScale);

        //position_1 = new Vector3(1f, 1f, 1f);
        //position_2 = new Vector3(1f, 1f, 1f);

        //if (Vector3.Equals(position_1, position_2)) // pozisyonları eşit mi?
        //{
        //    Debug.Log("Equal");
        //}
        //else
        //    Debug.Log("Not equal");


        //start_time = Time.time;


        //Vector3 pos1 = new Vector3(1f, 3f, 2f);
        //Vector3 pos2 = new Vector3(5f, 1f, 4f);

        //print(Vector3.Max(pos1,pos2)); // iki vektörün en büüyk koordinatlarını alır. örnek için (5f,3f,4f) olacak
        //print(Vector3.Min(pos1, pos2)); // mxın tam tersini yapar (1f,1f,2f)
        //print(Vector3.Scale(pos1, pos2)); // iki vektörün doğrusal  çarpımını verir (5f,3f,8f)


        //transform.position.x  : objenin x eksenindeki konumu
        //transform.position = new Vector3(transform.position.x, 8f, transform.position.z); // obje sadece Y ekseninde ışınlanır (yer değiştirilir)



        //GameObject child_obj = transform.Find("ChildObj").gameObject;
        //child_obj.name = "Child_Obj";

        //GameObject child_obj2 = transform.Find("Child_Obj/ChildObj2").gameObject; // üstte isim değiştiği için Child_Obj/ChildObj2 şeklinde olması gerek
        //child_obj2.name = "Child_Obj2";

        //print(transform.childCount);
        //print(transform.hierarchyCount);


        //print(transform.GetChild(0).name);
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    print(transform.GetChild(i).name);
        //}


        //SetParent: İki objeden birini diğerinin ebeveyni yaparak hiyerarşi sağlar
        //child.transform.SetParent(parent);
        //child.transform.SetParent(parent,false);



        //transform.rotation = Quaternion.Euler(45,45,25);

        //Vector3 new_pos = new Vector3(140, 35, 35);
        //Quaternion new_quat = Quaternion.Euler(new_pos);
        //transform.rotation = new_quat;


        //transform.rotation = Quaternion.identity; // objenin açılarını 0'a eşitler yani sıfırlar

    }


    void Update()
    {

        // Translate: objenin sürekli hareket etmesini sağlar.

        //transform.Translate(new Vector3(1f, 1f, 1f) * Time.deltaTime); // Time.deltaTime ile objenin bir anda değil saniyede pozisyon değiştirme yapması sağlanır.
        //transform.Translate(Vector3.back *5f* Time.deltaTime);

        // Debug.Log(Vector3.Magnitude(transform.position)); // bir vektörün uzunluğunu verir 
        //Debug.Log(Vector3.SqrMagnitude(transform.position));



        // static methods

        //Vector3 distance_ = a.position - transform.position;
        //float angle_ = Vector3.Angle(distance_, transform.forward);
        //Debug.Log(angle_); // aradaki açı farkı



        //float diff_dis = Vector3.Distance(a.position, b.position); // iki vektör arasındaki mesafe farkı
        //Debug.Log(diff_dis);


        // lerp : iki obje arasında görünmez bir doğru oluşturur ve bu doğru boyunca bir objeyi hareket ettirebiliriz.

        // transform.position = Vector3.Lerp(a.position, b.position,(Time.time - start_time) *.5f);

        // Time.time = oyun başladığından itibaren geçen zamanı verir
        // Time.deltaTime = bir karenin işleme alınıp işlemin bitmesi arasındaki zaman farkını verir.
        // Time.scaleTime = oyundaki geçen zamanın ölçeğini değiştirir. 0.5f zaman geçişi yarı yarıya uzar yani 1 saniye 2 saniye olur. 0 olursa zaman durur.


        // Rotate: objenin sürekli dönmesini sağlar.

        //transform.Rotate(new Vector3(1f, 0f, 0f) * Time.deltaTime * 40f);
        //a.Rotate(0f, 1f, 0f, Space.World);
        //b.Rotate(0f, 1f, 0f, Space.Self);

        // LookAt: bir objenin diğer objeyi bakış olarak takip etmesini sağlar.
        //a.transform.LookAt(b); //a.LookAt(b); bu da oldu denemek lazım




        // Quaternion: açısal işlemler yapabilen sınıf

        //Vector3 diff_ = parent.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(diff_, Vector3.up);  // LookAt fonksiyonu ile aynı işlemi yapar

        //float angle_ = Quaternion.Angle(transform.rotation, parent.rotation);
        //print(angle_);

        //transform.rotation = Quaternion.Inverse(parent.rotation); // ayna işlevi görür, takip edilen objenin tersi yöne dönme yapar.

        //transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); //kendi ekseninde döner




    }
}
