using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tese : MonoBehaviour
{

    /*��׽֡��Ϊ��Ļ��ͼ���С�
    ͼ����PNG�ļ�����ʽ�洢��һ���ļ����С�����Щ�ļ�������ϳ�һ��ʹ��ͼ�񹤾����(��QuickTime Pro)�ĵ�Ӱ��
    ������ͼ���ļ��С�����ļ��д��ڣ����ǽ�׷������������һ�����ļ��С�*/
    string folder = "ScreenshotFolder";
    int frameRate = 25;

    public bool use = false;

    void Start()
    {
        //���ûط�֡��(ʵʱ����Ϸʱ���޹�)��
        Time.captureFramerate = frameRate;
        //�����ļ���
        System.IO.Directory.CreateDirectory(folder);
    }

    void Update()
    {
        if(use)
        {
            // ���ļ������ӵ��ļ�������(��ʽΪ'0005 shot.png ')
            string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);
            //����Ļ��ͼ����ָ���ļ���
            Debug.Log("��ͼ�ɹ�");
            ScreenCapture.CaptureScreenshot(name,3);
            use = false;
        }
    }
}
