using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _uvelichitel : MonoBehaviour
{

  public Material grey;//ссылка на внешний материал


  public void HowerEnter()
  {
    GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    //Фукнция меняющая цвет определенного объекта при наведении мыши на определенную кнопку
  }

  public void HowerExit()
  {
    GetComponent<Renderer>().material = grey;
    //Фукнция возвращающаяся материал определенного объекта при убирании мыши с определенной кнопки
  }

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
