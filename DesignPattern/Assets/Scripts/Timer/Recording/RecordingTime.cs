using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Ifly_PublicRes
{
    public class RecordingTime : MonoBehaviour
    {
        public TextMeshProUGUI timeTxt = null;
        public float totalTime = 3.0f;
        private Animator anim = null;
        private MyTimer recordingTimer = new MyTimer();
        private bool recording = false;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        // Start is called before the first frame update
        void Start()
        {
            anim.Play("Empty");
            timeTxt.text = GetTimeTxt(0) + "/" + GetTimeTxt((int)totalTime);
        }

        // Update is called once per frame
        void Update()
        {
            if (recording)
            {
                recordingTimer.Tick();
                timeTxt.text = GetTimeTxt((int)recordingTimer.ElpsedTime) + "/" + GetTimeTxt((int)totalTime);
                if (recordingTimer.state == MyTimer.STATE.FINISHED)
                {
                    StopRecording();
                }
            }
        }

        public void StartRecording()
        {
            Debug.Log("RecordingStart");
            anim.Play("Recording");
            recordingTimer.duration = totalTime;
            recordingTimer.Go();
            recording = true;
        }

        private void StopRecording()
        {
            anim.Play("Empty");
            recording = false;
            //timeTxt.text = GetTimeTxt(0) + "/" + GetTimeTxt((int)totalTime);
            Debug.Log("RecordingFinished");
        }

        // 返回格式 HH：mm：ss
        public string GetTimeTxt(int second)
        {
            string dstTxt = "";
            // 小时
            int hour = second / 3600;
            dstTxt += (hour >= 10) ? hour + ":" : "0" + hour + ":";
            // 分钟
            int min = second % 3600 / 60;
            dstTxt += (min >= 10) ? min + ":" : "0" + min + ":";
            // 秒钟
            int sec = second % 3600 % 60;
            dstTxt += (sec >= 10) ? sec.ToString() : "0" + sec;

            return dstTxt;
        }
    }
}
