using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tese : MonoBehaviour
{

    /*捕捉帧作为屏幕截图序列。
    图像以PNG文件的形式存储在一个文件夹中——这些文件可以组合成一部使用图像工具软件(如QuickTime Pro)的电影。
    包含截图的文件夹。如果文件夹存在，我们将追加数字来创建一个空文件夹。*/
    string folder = "ScreenshotFolder";
    int frameRate = 25;

    public bool use = false;

    void Start()
    {
        //设置回放帧率(实时与游戏时间无关)。
        Time.captureFramerate = frameRate;
        //创建文件夹
        System.IO.Directory.CreateDirectory(folder);
    }

    void Update()
    {
        if(use)
        {
            // 将文件名附加到文件夹名称(格式为'0005 shot.png ')
            string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);
            //将屏幕截图捕获到指定文件夹
            Debug.Log("截图成功");
            ScreenCapture.CaptureScreenshot(name,3);
            use = false;
        }
    }
}
