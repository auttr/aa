using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace aa
{
    ///<summary>
    ///API �R�A�ϥΤ覡
    ///</summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            print("���x�O" + Application.platform);
            print($"�`�@{Camera.allCamerasCount}�Ӭ۾�");
            Time.timeScale = 0.5f;
            print("�h���p���I" + Mathf.Floor(9.999f));
            print("�h���p���I" + Mathf.FloorToInt(9.999f));
            print("�Z����" + Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22)));
            Physics.sleepThreshold = 10;
            Application.OpenURL("https://unity.com/");
        }
        private void Update()
        {
            if (Input.anyKeyDown)
            {
                print("��anykey");
                print(Time.unscaledTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("�ť���");
               
            }

        }
    }
}

