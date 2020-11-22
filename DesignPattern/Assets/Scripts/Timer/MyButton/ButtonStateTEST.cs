using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ifly_PublicRes
{
    public class ButtonStateTEST : MonoBehaviour
    {
        public MyButton button = new MyButton();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            button.Tick(Input.GetKey(KeyCode.Space));

            if (button.OnPressed)
            {
                Debug.Log("刚刚按下");
            }
            if (button.IsDelaying)
            {
                Debug.Log("刚刚按下开始的延迟");
            }
            if (button.IsPressing)
            {
                Debug.Log("正在按");
            }
            if (button.OnReleased)
            {
                Debug.Log("刚刚释放");
            }

            if (button.IsExtending)
            {
                Debug.Log("刚刚释放开始的延迟");
            }
        }
    }
}
