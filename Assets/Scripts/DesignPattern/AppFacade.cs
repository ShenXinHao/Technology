#region Date

// Create by Shenxinhao
// 2023年04月20日 星期四 23:29

#endregion

using System;
using DesignPattern.Command;
using UnityEngine;

namespace DesignPattern
{
    public class AppFacade : MonoBehaviour
    {
        private void Awake()
        {
            GameManager.Instance.Init();
        }
    }
}