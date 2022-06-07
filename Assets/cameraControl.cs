using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{

  public Camera MainCamera;//ссылка на объект камеры
  public Camera TempCamera;//ссылка на объект камеры



  // Use this for initialization
  void Start()
  {
    MainCamera.enabled = false;//поумолчанию камера выключена
    TempCamera.enabled = true;//поумолчанию камера включена

  }


  public void ChangeCamera()//функция переключения камер
  {
    TempCamera.enabled = false;
    MainCamera.enabled = true;
  }


  // Update is called once per frame
  void Update()
  {

  }
}
