using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempCamera : MonoBehaviour
{


  //Объявляем все необходимые переменные
  [SerializeField]
  Transform targetPos;
  int maxdistance = 20;
  [SerializeField]
  int mindistance = 1;
  [SerializeField]


  bool ControlDistance(float distance)
  {
    if (distance > mindistance && distance < maxdistance) return true;
    return false;
    //Если дистанция больше минимальной и меньше максимальной, возвращаем true, иначе false
  }

  // Use this for initialization
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {

    transform.RotateAround(targetPos.position, Vector3.up, 10 * Time.deltaTime); //изменяем положение камеры в сферической системе координат
  }
}
