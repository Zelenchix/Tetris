using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum TetrinoFigure
{
    L,
    Z,
    I,
    O,
    T
}

public class My_tetrino_data : MonoBehaviour
{
    private GameObject pref_cube;// будет использоваться для хранения префаба куба
    private GameObject[] my_tetrino_array;// для хранения игровых объектов 
    private int my_rotation;//будет хранить текущий угол поворота 
    private TetrinoFigure my_type;

    private void Awake()// вызывается, когда объект на сцене загружается
    {
        my_rotation = 0;//Устанавливает начальное значение переменной 
        my_tetrino_array = new GameObject[4];//Создает новый массив размером 4
        pref_cube = Resources.Load("my_prefab/my_prefab_cube") as GameObject;
    }//Загружает префаб куба из ресурсов с именем "my_prefab/my_prefab_cube" и присваивает его переменной pref_cube

    public void MyInitialize(TetrinoFigure _myType)//Этот метод через который мы передаем тип фигуры тетриса, чтобы начать работу с ней
    {// Он используется для установки начальных параметров этой фигуры, чтобы она выглядела и работала правильно в игре
        for (int i = 0; i < transform.childCount; i++)//Цикл для удаления всех дочерних объектов текущего объекта
            Destroy(transform.GetChild(i).gameObject);//Удаляет каждый дочерний объект текущего объекта

        switch (_myType)//Начинает конструкцию switch-case, проверяя значение _myType
        {
            case TetrinoFigure.L://Если _myType равен TetrinoFigure.L, выполняются следующее
                my_type = _myType;//Присваивает переменной my_type значение _myType.
                GameObject obL = Instantiate(pref_cube, new Vector3(), Quaternion.identity);//Этот код создаёт новый игровой объект obL из префаба pref_cube в позиции (0, 0, 0) без вращения.
                obL.AddComponent<my_tetrino_segment>();//Вызывается метод AddComponent, который добавляет компонент my_tetrino_segment к объекту obL
                obL.transform.SetParent(transform, false);//Устанавливаем родителя объекта obL таким же, как у текущего объекта
                GameObject obL2 = Instantiate(pref_cube, new Vector3(0, 1, 0), Quaternion.identity);//Создаем новый объект obL2 и помещаем его в позицию (0, 1, 0).
                obL2.AddComponent <my_tetrino_segment>();//Добавляем к объекту obL2 компонент my_tetrino_segment
                obL2.transform.SetParent(transform, false);//Устанавливаем родителя объекта obL2 таким же, как у текущего объекта.
                GameObject obL3 = Instantiate(pref_cube, new Vector3(0, -1, 0), Quaternion.identity);
                obL3.AddComponent<my_tetrino_segment>();
                obL3.transform.SetParent(transform, false);
                GameObject obL4 = Instantiate(pref_cube, new Vector3(1, -1, 0), Quaternion.identity);
                obL4.AddComponent<my_tetrino_segment>();
                obL4.transform.SetParent(transform, false);
                //В цикле проходится по массиву my_tetrino_array и каждому его элементу присваивается объект, являющийся ребенком текущего объекта.
                for (int i = 0; i < my_tetrino_array.Length; i++)
                    my_tetrino_array[i] = transform.GetChild(i).gameObject;
                break;//Завершает конструкцию switch-case.
            
            case TetrinoFigure.Z:
                my_type = _myType;
                GameObject obZ = Instantiate(pref_cube, new Vector3(), Quaternion.identity);
                obZ.AddComponent<my_tetrino_segment>();
                obZ.transform.SetParent(transform, false);
                GameObject obZ2 = Instantiate(pref_cube, new Vector3(0, 1, 0), Quaternion.identity);
                obZ2.AddComponent<my_tetrino_segment>();
                obZ2.transform.SetParent(transform, false);
                GameObject obZ3 = Instantiate(pref_cube, new Vector3(-1, 1, 0), Quaternion.identity);
                obZ3.AddComponent<my_tetrino_segment>();
                obZ3.transform.SetParent(transform, false);
                GameObject obZ4 = Instantiate(pref_cube, new Vector3(1, 0, 0), Quaternion.identity);
                obZ4.AddComponent<my_tetrino_segment>();
                obZ4.transform.SetParent(transform, false);
                for (int i = 0; i < my_tetrino_array.Length; i++)
                    my_tetrino_array[i] = transform.GetChild(i).gameObject;
                break;
            
            case TetrinoFigure.I:
                my_type = _myType;
                GameObject obI = Instantiate(pref_cube, new Vector3(), Quaternion.identity);
                obI.AddComponent<my_tetrino_segment>();
                obI.transform.SetParent(transform, false);
                GameObject obI2 = Instantiate(pref_cube, new Vector3(0, -1, 0), Quaternion.identity);
                obI2.AddComponent<my_tetrino_segment>();
                obI2.transform.SetParent(transform, false);
                GameObject obI3 = Instantiate(pref_cube, new Vector3(0, 1, 0), Quaternion.identity);
                obI3.AddComponent<my_tetrino_segment>();
                obI3.transform.SetParent(transform, false);
                GameObject obI4 = Instantiate(pref_cube, new Vector3(0, 2, 0), Quaternion.identity);
                obI4.AddComponent<my_tetrino_segment>();
                obI4.transform.SetParent(transform, false);
                for (int i = 0; i < my_tetrino_array.Length; i++)
                    my_tetrino_array[i] = transform.GetChild(i).gameObject;
                break;
            
            case TetrinoFigure.O:
                my_type = _myType;
                GameObject obO = Instantiate(pref_cube, new Vector3(), Quaternion.identity);
                obO.AddComponent<my_tetrino_segment>();
                obO.transform.SetParent(transform, false);
                GameObject obO2 = Instantiate(pref_cube, new Vector3(-1, 0, 0), Quaternion.identity);
                obO2.AddComponent<my_tetrino_segment>();
                obO2.transform.SetParent(transform, false);
                GameObject obO3 = Instantiate(pref_cube, new Vector3(-1, -1, 0), Quaternion.identity);
                obO3.AddComponent<my_tetrino_segment>();
                obO3.transform.SetParent(transform, false);
                GameObject obO4 = Instantiate(pref_cube, new Vector3(0, -1, 0), Quaternion.identity);
                obO4.AddComponent<my_tetrino_segment>();
                obO4.transform.SetParent(transform, false);
                for (int i = 0; i < my_tetrino_array.Length; i++)
                    my_tetrino_array[i] = transform.GetChild(i).gameObject;
                break;
            
            case TetrinoFigure.T:
                my_type = _myType;
                GameObject obT = Instantiate(pref_cube, new Vector3(), Quaternion.identity);
                obT.AddComponent<my_tetrino_segment>();
                obT.transform.SetParent(transform, false);

                GameObject obT2 = (GameObject)Instantiate(pref_cube, new Vector3(1, 0, 0), Quaternion.identity);
                obT2.AddComponent<my_tetrino_segment>();
                obT2.transform.SetParent(transform, false);

                GameObject obT3 = Instantiate(pref_cube, new Vector3(-1, 0, 0), Quaternion.identity);
                obT3.AddComponent<my_tetrino_segment>();
                obT3.transform.SetParent(transform, false);

                GameObject obT4 = Instantiate(pref_cube, new Vector3(0, 1, 0), Quaternion.identity);
                obT4.AddComponent<my_tetrino_segment>();
                obT4.transform.SetParent(transform, false);

                for (int i = 0; i < my_tetrino_array.Length; i++)
                    my_tetrino_array[i] = transform.GetChild(i).gameObject;
                break;
            default:
                break;
        }
    }
}