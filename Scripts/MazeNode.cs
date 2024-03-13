using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Это перечисление NodeState определяет состояния узла
public enum NodeState
{
    Available, // Доступный
    Current, // Текущий
    Completed // Завершенный
}
// Класс MazeNode представляет узел лабиринта
public class MazeNode : MonoBehaviour
{
    [SerializeField] GameObject[] walls; // Массив стен узла
    [SerializeField] MeshRenderer floor; // Плоскость узла
                                         // Метод RemoveWall используется для удаления стены узла по индексу
    public void RemoveWall(int wallToRemove)
    {
        walls[wallToRemove].gameObject.SetActive(false); // Деактивируем стену
    }
    // Метод SetState используется для установки состояния узла
    public void SetState(NodeState state)
    {
        switch (state)
        {
            case NodeState.Available:
                floor.material.color = Color.white; // Устанавливаем белый цвет для доступного состояния
                break;
            case NodeState.Current:
                floor.material.color = Color.yellow; // Устанавливаем желтый цвет для текущего состояния
                break;
            case NodeState.Completed:
                floor.material.color = Color.blue; // Устанавливаем синий цвет для завершенного состояния
                break;
        }
    }
}