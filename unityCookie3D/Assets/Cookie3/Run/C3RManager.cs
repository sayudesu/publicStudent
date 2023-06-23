using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C3RManager : MonoBehaviour
{
    GameObject cookie;

    // Start is called before the first frame update
    void Start()
    {
        cookie = GameObject.Find("C3RunCookie");
    }

    // Update is called once per frame
    void Update()
    {
        //初期位置に戻る
        if (cookie.transform.position.y < - 2.4f)
        {
            cookie.transform.position = new Vector3(0, 1.2f, 0);
        }

        //クリア
        if(cookie.transform.position.z > 104)
        {
            SceneManager.LoadScene("Cookie3/Cookie3");
        }

           
    }
}
