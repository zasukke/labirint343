using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ��� ������������ NodeState ���������� ��������� ����
public enum NodeState
{
    Available, // ���������
    Current, // �������
    Completed // �����������
}
// ����� MazeNode ������������ ���� ���������
public class MazeNode : MonoBehaviour
{
    [SerializeField] GameObject[] walls; // ������ ���� ����
    [SerializeField] MeshRenderer floor; // ��������� ����
                                         // ����� RemoveWall ������������ ��� �������� ����� ���� �� �������
    public void RemoveWall(int wallToRemove)
    {
        walls[wallToRemove].gameObject.SetActive(false); // ������������ �����
    }
    // ����� SetState ������������ ��� ��������� ��������� ����
    public void SetState(NodeState state)
    {
        switch (state)
        {
            case NodeState.Available:
                floor.material.color = Color.white; // ������������� ����� ���� ��� ���������� ���������
                break;
            case NodeState.Current:
                floor.material.color = Color.yellow; // ������������� ������ ���� ��� �������� ���������
                break;
            case NodeState.Completed:
                floor.material.color = Color.blue; // ������������� ����� ���� ��� ������������ ���������
                break;
        }
    }
}