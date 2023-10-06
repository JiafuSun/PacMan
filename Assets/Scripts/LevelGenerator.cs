using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class LevelGenerator : MonoBehaviour
{
    public List<GameObject> m_MapTileList;

    //��ͼ��Ϣ
    private int[,] levelMap =
     {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,6,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,5,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
     };

   
    void Start()
    {
        //���ɵ�ͼ
        FullMapCreate(); 
    }

    //���ŵ�ͼ����
    public void FullMapCreate()
    {
        GameObject LeftTopMap = new GameObject();
        LeftTopMap.name = "���ϱߵ�ͼ";
        CreateMap(LeftTopMap.transform);

        GameObject RightTopMap = new GameObject();
        RightTopMap.name = "���ϱߵ�ͼ";
        CreateMap(RightTopMap.transform);
        //����
        RightTopMap.transform.localScale = new Vector3(-1, 1, 1);
        RightTopMap.transform.position = new Vector3(27, 0, 0);



        GameObject LeftButtomMap = new GameObject();
        LeftButtomMap.name = "���±ߵ�ͼ";
        CreateMap(LeftButtomMap.transform);
        //����
        LeftButtomMap.transform.localScale = new Vector3(1, -1, 1);
        LeftButtomMap.transform.position = new Vector3(0, -27, 0);


        GameObject RightButtomMap = new GameObject();
        RightButtomMap.name = "���±ߵ�ͼ";
        CreateMap(RightButtomMap.transform);
        //����
        RightButtomMap.transform.localScale = new Vector3(-1, -1, 1);
        RightButtomMap.transform.position = new Vector3(27, -27, 0); 
    }

    //�ķ�֮һ��ͼ����
    public void CreateMap(Transform pa)
    {  
        for (int i = 0; i < levelMap.GetLength(0); i++)
        {
            for (int j = 0; j < levelMap.GetLength(1); j++)
            {
                GameObject obj = GameObject.Instantiate(m_MapTileList[levelMap[i, j]], new Vector3(j, -i, 0), Quaternion.identity);


                if ((i == 1 && j == 0) ||
                    (i == 2 && j == 0) ||
                    (i == 3 && j == 0) ||
                    (i == 4 && j == 0) ||
                    (i == 5 && j == 0) ||
                    (i == 6 && j == 0) ||
                    (i == 7 && j == 0) ||
                    (i == 8 && j == 0) ||
                    (i == 2 && j == 3) ||
                    (i == 2 && j == 4) ||
                    (i == 2 && j == 8) ||
                    (i == 2 && j == 9) ||
                    (i == 2 && j == 10) ||
                    (i == 4 && j == 3) ||
                    (i == 4 && j == 4) ||
                    (i == 4 && j == 8) ||
                    (i == 4 && j == 9) ||
                    (i == 4 && j == 10) ||
                    (i == 6 && j == 3) ||
                    (i == 6 && j == 4) ||
                    (i == 6 && j == 11) ||
                    (i == 6 && j == 12) ||
                    (i == 6 && j == 13) ||
                    (i == 7 && j == 3) ||
                    (i == 7 && j == 4) ||
                    (i == 7 && j == 11) ||
                    (i == 7 && j == 12) ||
                    (i == 9 && j == 9) ||
                    (i == 9 && j == 10) ||
                    (i == 10 && j == 5) ||
                    (i == 10 && j == 9) ||
                    (i == 10 && j == 10) ||
                    (i == 11 && j == 5) ||
                    (i == 12 && j == 5) ||
                    (i == 12 && j == 11) ||
                    (i == 12 && j == 12) ||
                    //  (i == 13 && j == 0)|| 

                    //3 
                    (i == 4 && j == 13) ||
                    (i == 4 && j == 2) ||
                    (i == 4 && j == 5) ||
                    (i == 4 && j == 7) ||
                    (i == 4 && j == 11) ||
                    (i == 9 && j == 0) ||
                    (i == 7 && j == 2) ||
                    (i == 7 && j == 10) ||
                    (i == 9 && j == 8) ||
                    (i == 10 && j == 13) ||
                    (i == 13 && j == 7)


                    )
                {
                    obj.transform.rotation = Quaternion.Euler(0, 0, 90);
                }

                if ((i == 4 && j == 5) ||
                    (i == 4 && j == 11) ||
                     (i == 7 && j == 5) ||
                     (i == 10 && j == 11) ||
                      (i == 13 && j == 5) ||
                      (i == 13 && j == 8)

                    )


                {
                    obj.transform.rotation = Quaternion.Euler(0, 0, 180);
                }


                if ((i == 2 && j == 5) ||
                     (i == 2 && j == 11) ||
                     (i == 6 && j == 5) ||
                    (i == 6 && j == 8) ||
                    (i == 7 && j == 13) ||
                     (i == 9 && j == 5) ||
                     (i == 9 && j == 11)



                    )
                {
                    obj.transform.rotation = Quaternion.Euler(0, 0, 270);
                }

                //��ÿһ��������������
                obj.transform.SetParent(pa.transform);

            }
        }
    }
      
}
