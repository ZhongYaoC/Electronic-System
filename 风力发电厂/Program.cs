﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风力发电厂
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

/*
 # Electronic-System 海上风力发电系统

## 系统功能
(一) 用户权限管理
1. 用户信息录入
2. 用户授权处理
3. 用户登陆验证

（二）维护活动管理系统
1. 基础信息管理：人员管理、供应商管理、技术资料
2. 运作管理：风机状态监控、风机出力情况
3. 维护活动管理：维护需求、维修计划、维修实施、维修报告
4. 设备管理：备件管理、船舶管理
5. 系统日志管理
     */
