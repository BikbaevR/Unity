using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{

  //Объявляем все необходимые переменные
  bool move = false;
  Vector3 startPosition;
  Vector3 needPosition;
  float speed = 0.01f;
  float offset = 0;
  Quaternion startRotation;
  //Quaternion needRotation;





  public void dvij()
  {
    move = true;
  }



  // Use this for initialization
  void Start()
  {

    needPosition = new Vector3(2, 3, 19);
    //needRotation = new Quaternion (0, 0, 0, 0);
  }

  // Update is called once per frame
  void Update()
  {

    startPosition = transform.position;
    startRotation = transform.rotation;

    if (move)
    {
      offset += speed;
      transform.position = Vector3.Lerp(startPosition, needPosition, offset);
      //transform.rotation = Quaternion.Slerp (startRotation, needRotation, offset);

      if (offset >= 1)
      {
        move = false;
        offset = 0;
      }
    }
  }
}

