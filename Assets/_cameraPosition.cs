using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _cameraPosition : MonoBehaviour
{

  //объявляем необходимые переменные
  bool move = false;
  Vector3 startPosition;
  Vector3 needPosition;
  float speed = 0.01f;
  float offset = 0;
  Quaternion startRotation;
  Quaternion needRotaton;

  //ссылка на камеру
  public Camera mainCamera;




  public void MoveKrishka()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(1.8f, 2.4f, 18f);
      needRotaton = Quaternion.AngleAxis(-59f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  public void MoveOculyar()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.4f, 2.25f, 14.8f);
      needRotaton = Quaternion.AngleAxis(0f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  public void MoveKrutilka()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(1.8f, 2.4f, 18f);
      needRotaton = Quaternion.AngleAxis(-59f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  public void MoveVoda()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-2.3f, 2.7f, 17.3f);
      needRotaton = Quaternion.AngleAxis(0f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }


  public void MoveStart()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-1.46f, 2.94f, 14.8f);
      needRotaton = Quaternion.AngleAxis(0f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }

  public void MoveGlazok()
  {
    if (!move)
    {
      move = true;
      needPosition = new Vector3(-0.45f, 1.87f, 18.5f);
      needRotaton = Quaternion.AngleAxis(0f, new Vector3(0, 1, 0));
      //позиция и угол поворота для камеры
    }

  }




  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //Проверяем позицию камеры в реальном времени
    startRotation = mainCamera.transform.rotation;
    startPosition = mainCamera.transform.position;

    if (move)//если нажата кнопка перемещения камеры
    {
      offset += speed;//данная конструкция увеливает скорость передвижения по времени
      mainCamera.transform.position = Vector3.Lerp(startPosition, needPosition, offset);//плавно изменяем позицию
      mainCamera.transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);//плавно измеяем угол поворота

      if (offset >= 1)
      {
        move = false;
        offset = 0;
      }

    }
  }
}
