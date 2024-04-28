using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_main : MonoBehaviour
{
  private const int wid = 13, hei = 21;// пределяют ширину и высоту игрового поля 
  private float my_step = 1;//определяет размер шага для перемещения фигур.
  
  private GameObject pref_tetrino;// это ссылка на префаб, который будет использоваться для создания фигур тетриса
  private my_tetrino_figure my_figure;//переменная, которая будет содержать текущую фигуру, над которой пользователь работает.

  private void Start()//вызывается при запуске игры
  {
    pref_tetrino = Resources.Load("my_prefab/my_tetrino_figure") as GameObject;
    CreteFigure(TetrinoFigure.L);//и создаёт фигуру с помощью функции CreateFigure, передавая тип фигуры L
  }
  

  private void CreteFigure(TetrinoFigure _figure)// создает фигуру тетриса на основе указанного типа _figure
  {//Он создает копию объекта pref_tetrino на игровой сцене в определенном месте и затем настраивает данные этой фигуры.
    my_figure = Instantiate(pref_tetrino, new Vector3(my_step * 6, my_step * (hei - 2)),
      Quaternion.identity).GetComponent<my_tetrino_figure>();
    
    my_figure.GetComponentInChildren<My_tetrino_data>().MyInitialize(_figure);
  }
}
