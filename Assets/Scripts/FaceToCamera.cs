using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceToCamera : MonoBehaviour
{

    // public int GraspModel = 0;
    // Start is called before the first frame update

    Transform m_cam_main_Transform; // 定义个transform变量
    public Vector3 m_Rot; // 脚本宿主的旋转角变量，最后会传递给宿主
    public Vector3 m_Positon;// 宿主的位置
    public Vector3 m_cam_Rot; // 主相机的旋转角
    public Vector3 m_Cam_Positon; //主相机的位置
    public bool reverse = false;
    /// <summary>
    /// 初始化的时候就使宿主面向用户
    /// </summary>
    void Start()
    {
        m_cam_main_Transform = Camera.main.transform; //获得主相机的属性
        m_Cam_Positon = m_cam_main_Transform.position;//获得主相机的位置
        m_Positon = this.transform.position;//获得宿主的位置
        Vector3 Dire = m_Cam_Positon - m_Positon; // 求向量，由宿主指向主相机
        Dire = Dire.normalized; //标准化，只取向量的方向
        if (reverse)
        {
            Dire = -Dire;
        }
        m_Rot = Dire; //宿主的方向为向量的方向
        this.transform.forward = m_Rot; // 宿主的方向指向主相机
    }
    // Update is called once per frame
    /// <summary>
    /// 让宿主保持面向主相机
    /// </summary>
    void Update()
    {
        // 和初始化一样
        m_Cam_Positon = m_cam_main_Transform.position;
        m_Positon = this.transform.position;
        Vector3 Dire = m_Cam_Positon - m_Positon;
        Dire = Dire.normalized;
        if (reverse)
        {
            Dire = -Dire;
        }

        m_Rot = Dire;
        this.transform.forward = m_Rot; // 宿主的方向指向主相机


    }


}
