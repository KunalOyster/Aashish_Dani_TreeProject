using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject stage1,stage2,stage3,stage4,stage5,stage6,stage7,stage8,stage9;


    
    // panels
    public GameObject stagesPanel;

    public void ActiveStage1()
    {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage2()
    {
        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage3()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage4()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(true);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage5()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(true);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage6()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(true);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage7()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(true);
        stage8.SetActive(false);
        stage9.SetActive(false);
    }

    public void ActiveStage8()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(true);
        stage9.SetActive(false);
    }

    public void ActiveStage9()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(true);
    }



    // All the panels are below this
    public void ActiveStagesPanel()
    {
        if(stagesPanel.activeInHierarchy)
        {
            stagesPanel.SetActive(false);
        }
        else
        {
            stagesPanel.SetActive(true);
        }
    }
}
