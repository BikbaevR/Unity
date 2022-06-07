using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water : MonoBehaviour
{

  //объявляем необходимые переменные и ссылки на объекты
  public button buttonScript;

  Vector3 needPosition;
  Vector3 startPosition;

  Vector3 startPositionTwo;
  Vector3 startPositionThree;

  bool moveOne = false;
  bool moveTwo = false;
  bool moveTree = false;


  bool moveOneOut = false;
  bool moveTwoOut = false;
  bool moveTreeOut = false;

  public float speed = 0.01f;
  public float offset = 0;

  public GameObject waterTube_1;
  public GameObject waterTube_2;
  public GameObject waterTube_3;

  public bool waterOneIsPos = false;
  public bool waterTwoIsPos = false;
  public bool waterTreeIsPos = false;

  public oculyar_script oculyar_Script;


  //x = z
  //y = x
  //z = y

  // Use this for initialization
  void Start()
  {
    //устанавливаем начальные значения
    startPosition = new Vector3(-2.076f, 1.449f, 20.147f); //waterTube_1.transform.position;
    needPosition = new Vector3(-0.432f, 1.864f, 19.962f);
    startPositionTwo = new Vector3(-2.274f, 1.449f, 20.147f);
    startPositionThree = new Vector3(-2.482f, 1.449f, 20.147f);
  }

  // Update is called once per frame
  void Update()
  {
    //Debug.Log (transform.position);
    if (moveOne)//движение перовго сосуда с жидкостью В
    {
      offset += speed;
      waterTube_1.transform.position = Vector3.Lerp(startPosition, needPosition, 1f);
    }
    if (waterTube_1.transform.position == needPosition)
    {
      waterOneIsPos = true;
    }
    else
    {
      waterOneIsPos = false;
    }

    if (moveTwo)//движение второго сосуда с жидкостью В
    {
      offset += speed;
      waterTube_2.transform.position = Vector3.Lerp(startPositionTwo, needPosition, 1f);
    }
    if (waterTube_2.transform.position == needPosition)
    {
      waterTwoIsPos = true;
    }
    else
    {
      waterTwoIsPos = false;
    }

    if (moveTree)//движение третьего сосуда с жидкостью В
    {
      offset += speed;
      waterTube_3.transform.position = Vector3.Lerp(startPositionThree, needPosition, 1f);
    }
    if (waterTube_3.transform.position == needPosition)
    {
      waterTreeIsPos = true;
    }
    else
    {
      waterTreeIsPos = false;
    }





    ///

    if (moveOneOut && waterOneIsPos)//движение перовго сосуда с жидкостью Из
    {
      offset += speed;
      waterTube_1.transform.position = Vector3.Lerp(needPosition, startPosition, 1f);
    }
    if (waterTube_1.transform.position == startPosition)
    {
      waterOneIsPos = false;
    }
    else
    {
      waterOneIsPos = true;
    }

    if (moveTwoOut && waterTwoIsPos)//движение второго сосуда с жидкостью ИЗ
    {
      offset += speed;
      waterTube_2.transform.position = Vector3.Lerp(needPosition, startPositionTwo, 1f);
    }
    if (waterTube_2.transform.position == startPositionTwo)
    {
      waterTwoIsPos = false;
    }
    else
    {
      waterTwoIsPos = true;
    }


    if (moveTreeOut && waterTreeIsPos)//движение третьего сосуда с жидкостью ИЗ
    {
      offset += speed;
      waterTube_3.transform.position = Vector3.Lerp(needPosition, startPositionThree, 1f);
    }
    if (waterTube_3.transform.position == startPositionThree)
    {
      waterTreeIsPos = false;
    }
    else
    {
      waterTreeIsPos = true;
    }

  }

  public void WaterOneInsert()//функция установки первого сосуда
  {
    if (!buttonScript.active)
    {
      moveOne = true;
      oculyar_Script.variable = 95;
      speed = 0.01f;
      offset = 0;
    }
  }

  public void WaterTwoInsert()//функция установки второго сосуда
  {
    if (!buttonScript.active)
    {
      moveTwo = true;
      oculyar_Script.variable = 100;
      speed = 0.01f;
      offset = 0;
    }
  }

  public void WaterTreeInsert()//функция установки третьего сосуда
  {
    if (!buttonScript.active)
    {
      moveTree = true;
      oculyar_Script.variable = 110;
      speed = 0.01f;
      offset = 0;
    }
  }

  public void WaterTubeOut()//функция убирания первого сосуда
  {
    if (!buttonScript.active && waterOneIsPos)
    {
      moveOneOut = true;
      oculyar_Script.variable = 0;
      speed = 0.01f;
      offset = 0;
    }

    if (!buttonScript.active && waterTwoIsPos)//функция убирания второго сосуда
    {
      moveTwoOut = true;
      oculyar_Script.variable = 0;
      speed = 0.01f;
      offset = 0;
    }

    if (!buttonScript.active && waterTreeIsPos)//функция убирания третьего сосуда
    {
      moveTreeOut = true;
      oculyar_Script.variable = 0;
      speed = 0.01f;
      offset = 0;
    }
  }
}









