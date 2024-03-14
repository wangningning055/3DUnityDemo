using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TestEvent;
public class MainUICtr
{
	MainUI view;
	public void Init()
	{

	}
	public MainUICtr(MainUI uiView)
	{
		view = uiView;
		view.UpLevel.onClick.AddListener(UpLevel);
		view.UpLevel.onClick.AddListener(SaveData);
		ListenerManager.Instance.RegistEvent(TestEvent.EventType.MainEvt2, UpdateData);
		ListenerManager.Instance.RegistEvent(TestEvent.EventType.MainEvt, RoleModule.Instance.UpLevel);
		Show();
	}
	void ChangePage()
	{

	}

	void UpLevel()
	{
		ListenerManager.Instance.TriggerEvent(TestEvent.EventType.MainEvt);
	}
	void SaveData()
	{
		RoleModule.Instance.data.SaveData();
	}

	void UpdateData()
	{
		view.Level.text = RoleModule.Instance.data.LevelPlayer.ToString();
		view.PlayerName.text = RoleModule.Instance.data.PlayerName;
	}
	void Show()
	{
		view.gameObject.SetActive(true);
		UpdateData();
	}

	void Hide()
	{
		view.gameObject.SetActive(false);
	}
}