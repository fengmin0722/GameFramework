﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

//开发阶段 资源放在Resources目录  以免每次打包AssetBundle
public class ResManager : MonoBehaviour 
{
    private static ResManager _instance;
    
    public static ResManager Instance
    {
        get { return GameManager.Instance.resMgr; }
    }
    public UnityEngine.Object Load(string path)
    {
        return Resources.Load(path);
    }
  
}