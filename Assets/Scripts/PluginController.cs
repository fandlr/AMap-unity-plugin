﻿using UnityEngine;

public class PluginController : MonoBehaviour
{
	#region CoreLocation集成

	public void StartGPSUpdate()
    {
		//Debug.Log("CoreLocation 开始定位");
		OSHookBridge.StartGPSUpdate();
    }

	public void StopGPSUpdate()
    {
        //Debug.Log("CoreLocation 结束定位");
		OSHookBridge.StopGPSUpdate();
    }

    #endregion

	#region 高德SDK集成

	public void LocateInit()
	{
		//Debug.Log("AMap 初始化定位");
		OSHookBridge.LocateInit();
	}

	public void LocateOnce()
	{
		//Debug.Log("AMap 单次定位");
		OSHookBridge.LocateOnce();
	}

	public void LocateUpdate()
	{
		//Debug.Log("AMap 持续定位");
		OSHookBridge.LocateUpdate();
	}

	public void LocateStop()
	{
		//Debug.Log("AMap 结束定位");
		OSHookBridge.LocateStop();
	}

    public void ShowMapView()
    {
		//Debug.Log("AMap 显示地图");
		//OSHookBridge.ShowMapView();
    }

    // UnitySendMessage回调
	public void IOSGPSUpdate(string log)
	{
		Debug.Log (log);
	}

	#endregion
}