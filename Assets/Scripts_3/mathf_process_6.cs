using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathf_process_6 : MonoBehaviour
{

    void Start()
    {

        //Abs: Mutlak değeri gösterir. 

        //print(Mathf.Abs(-2.5f)); // --> 2.5



        //Ceil: en büyük sayısa yuvarlar, 0.1 fazlası bile olsa yukarı yuvalar

        //print(Mathf.Ceil(5.0f)); // --> 5
        //print(Mathf.Ceil(5.2f)); // --> 6
        //print(Mathf.Ceil(5.7f)); // --> 6
        //print(Mathf.Ceil(-4.8f)); // --> -4



        //Floor: en küçük sayıya yuvalar, Ceil'in tam tersi yani

        //print(Mathf.Floor(-4.8f)); // --> -5
        //print(Mathf.Floor(3.1f)); // --> 3



        //Round: bildiğimiz şekli ile en yakın sayıya yuvarlama yapar. fakat eğer sayı 8.5 gibi çift rakam ise bunu 10'e yuvarlar

        //print(Mathf.Round(5.2f)); // --> 5
        //print(Mathf.Round(3.7f)); // -->  4

        //print(Mathf.Round(7.5f)); // -->  8
        //print(Mathf.Round(8.5f)); // -->  8



        /*  Clamp:
         *  ilk girilen, alt limit ve üst limit olarak verilen sayıları aşarsa, hangisini aştı ise o sayı gösterilir.
            örneğin - 25 sayısı 1 - 100 alt ve üst limit içierisinde alt limiti geçtiği için alt limit gösterilir yani 1
            163 sayısı üst limit olan 100'den fazla olduğu için bu sefer üst limit olarak 100 gösterilir.   */

        //print(Mathf.Clamp(45, 1, 100)); // 45
        //print(Mathf.Clamp(-25, 1, 100)); // 1 
        //print(Mathf.Clamp(163, 1, 100)); // 100



        //Clamp01: sayı negatif ise 0, pozitif ise 1 döner

        //print(Mathf.Clamp01(-45)); // 0
        //print(Mathf.Clamp01(45)); // 1




        // Max: verilen sayılar arasında en büyüğü döndürür. Dizi de verilebilir.

        //print(Mathf.Max(1.2f, 3.4f, 1.3f)); // 3.4

        //float[] numbers = new float[] {1.2f,4.5f,5.6f};
        //print(Mathf.Max(numbers)); // 5.6


        // Min: verilen sayılar arasında en küçüğü döndürür. Dizi de verilebilir.

        //print(Mathf.Min(1.2f, 3.4f, 1.3f)); // 1.2

        //float[] numbers = new float[] { 1.2f, 4.5f, 5.6f };
        //print(Mathf.Min(numbers)); // 1.2



    }



}
