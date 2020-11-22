using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ifly_PublicRes
{
    public class TriggerTEST : MonoBehaviour
    {
        public MyButton mouseClick = new MyButton();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            mouseClick.Tick(Input.GetMouseButton(0));
            if (mouseClick.OnPressed)
            {
                Debug.Log("你刚刚单击了");
            }
            if (mouseClick.IsExtending && mouseClick.OnPressed)
            {
                Debug.Log("你刚刚双击了");
            }
            if (mouseClick.IsDelaying && mouseClick.OnReleased)
            {
                Debug.Log("短按");
            }
            if (mouseClick.IsPressing)
            {
                Debug.Log("长按");
            }
        }
    }
}
