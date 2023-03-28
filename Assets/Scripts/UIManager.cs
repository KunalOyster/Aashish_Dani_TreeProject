using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject stage1,stage2,stage3,stage4,stage5,stage6,stage7,stage8,stage9;
    public GameObject testAnimTree;

    [Header("Panels")]
    // panels
    public GameObject stagesPanel;
    public GameObject infoPanel;

    [Header("Stage Button")]
    public Button stageBtn;
    public Sprite pressedStageImg, unPressedStageImg;

    [Header("Info Button")]
    public Button infoBtn;
    public Sprite pressedinfoImg, unPressedinfoImg;

    [Header("Details Button")]
    public GameObject detailsImage;
    public Button detailsBtn;
    public Sprite pressedDetailsImg, unPressedDetailsImg;

    [Header("Biogeography Button")]
    public GameObject biogeographyImage;
    public Button biogeographyBtn;
    public Sprite pressedBiogeographyImg, unPressedBiogeographyImg;

    [Header("Other Info Button")]
    public GameObject otherInfoImage;
    public Button otherInfoBtn;
    public Sprite pressedotherInfoImg, unPressedotherInfoImg;


    [Header("Young Stage Button")]
    public Button youngStageBtn;
    public Sprite pressedyoungStageImg, unPressedyoungStageImg;

    [Header("Middle Stage Button")]
    public Button middleStageBtn;
    public Sprite pressedmiddleStageImg, unPressedmiddleStageImg;

    [Header("Mature Stage Button")]
    public Button matureStageBtn;
    public Sprite pressedmatureStageImg, unPressedmatureStageImg;

    public void Start()
    {
        testAnimTree.SetActive(true);
    }

    public void ActiveStage1()
    {
        //
        detailsImage.SetActive(false);
        biogeographyImage.SetActive(false);
        otherInfoImage.SetActive(false);

        stage1.SetActive(true);
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
        testAnimTree.SetActive(false);

      



        // panels
        infoPanel.SetActive(false);


        // button images
        detailsBtn.image.sprite = unPressedDetailsImg;
        biogeographyBtn.image.sprite = unPressedBiogeographyImg;
        otherInfoBtn.image.sprite = unPressedotherInfoImg;
        youngStageBtn.image.sprite = pressedyoungStageImg;
        middleStageBtn.image.sprite = unPressedmiddleStageImg;
        matureStageBtn.image.sprite = unPressedmatureStageImg;
        infoBtn.image.sprite = unPressedinfoImg;

    }

    public void ActiveStage2()
    {

        //
        detailsImage.SetActive(false);
        biogeographyImage.SetActive(false);
        otherInfoImage.SetActive(false);

        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
        testAnimTree.SetActive(false);
        infoPanel.SetActive(false);

       




        // button images
        detailsBtn.image.sprite = unPressedDetailsImg;
        biogeographyBtn.image.sprite = unPressedBiogeographyImg;
        otherInfoBtn.image.sprite = unPressedotherInfoImg;
        youngStageBtn.image.sprite = unPressedyoungStageImg;
        middleStageBtn.image.sprite = pressedmiddleStageImg;
        matureStageBtn.image.sprite = unPressedmatureStageImg;
        infoBtn.image.sprite = unPressedinfoImg;

    }

    public void ActiveStage3()
    {

        //
        detailsImage.SetActive(false);
        biogeographyImage.SetActive(false);
        otherInfoImage.SetActive(false);



        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);
        stage4.SetActive(false);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage7.SetActive(false);
        stage8.SetActive(false);
        stage9.SetActive(false);
        testAnimTree.SetActive(false);
        infoPanel.SetActive(false);

       




        // button images
        detailsBtn.image.sprite = unPressedDetailsImg;
        biogeographyBtn.image.sprite = unPressedBiogeographyImg;
        otherInfoBtn.image.sprite = unPressedotherInfoImg;
        youngStageBtn.image.sprite = unPressedyoungStageImg;
        middleStageBtn.image.sprite = unPressedmiddleStageImg;
        matureStageBtn.image.sprite = pressedmatureStageImg;
        infoBtn.image.sprite = unPressedinfoImg;

    }

    //public void ActiveStage4()
    //{

    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);

    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(true);
    //    stage5.SetActive(false);
    //    stage6.SetActive(false);
    //    stage7.SetActive(false);
    //    stage8.SetActive(false);
    //    stage9.SetActive(false);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


        



    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;


    //}

    //public void ActiveStage5()
    //{

    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);


    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(false);
    //    stage5.SetActive(true);
    //    stage6.SetActive(false);
    //    stage7.SetActive(false);
    //    stage8.SetActive(false);
    //    stage9.SetActive(false);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


       



    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;

    //}

    //public void ActiveStage6()
    //{

    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);


    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(false);
    //    stage5.SetActive(false);
    //    stage6.SetActive(true);
    //    stage7.SetActive(false);
    //    stage8.SetActive(false);
    //    stage9.SetActive(false);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


        



    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;

    //}

    //public void ActiveStage7()
    //{
    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);


    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(false);
    //    stage5.SetActive(false);
    //    stage6.SetActive(false);
    //    stage7.SetActive(true);
    //    stage8.SetActive(false);
    //    stage9.SetActive(false);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


        



    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;

    //}

    //public void ActiveStage8()
    //{

    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);

    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(false);
    //    stage5.SetActive(false);
    //    stage6.SetActive(false);
    //    stage7.SetActive(false);
    //    stage8.SetActive(true);
    //    stage9.SetActive(false);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


        


    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;

    //}

    //public void ActiveStage9()
    //{

    //    //
    //    detailsImage.SetActive(false);
    //    biogeographyImage.SetActive(false);
    //    otherInfoImage.SetActive(false);

    //    stage1.SetActive(false);
    //    stage2.SetActive(false);
    //    stage3.SetActive(false);
    //    stage4.SetActive(false);
    //    stage5.SetActive(false);
    //    stage6.SetActive(false);
    //    stage7.SetActive(false);
    //    stage8.SetActive(false);
    //    stage9.SetActive(true);
    //    testAnimTree.SetActive(false);
    //    infoPanel.SetActive(false);


        


    //    // button images
    //    detailsBtn.image.sprite = unPressedDetailsImg;
    //    biogeographyBtn.image.sprite = unPressedBiogeographyImg;
    //    otherInfoBtn.image.sprite = unPressedotherInfoImg;
    //    youngStageBtn.image.sprite = unPressedyoungStageImg;
    //    middleStageBtn.image.sprite = unPressedmiddleStageImg;
    //    matureStageBtn.image.sprite = unPressedmatureStageImg;
    //    infoBtn.image.sprite = unPressedinfoImg;

    //}


    // Activate Images

    public void ActiveDetails() 
    {
        detailsImage.SetActive(true);
        biogeographyImage.SetActive(false);
        otherInfoImage.SetActive(false);
        detailsBtn.image.sprite = pressedDetailsImg;
        biogeographyBtn.image.sprite = unPressedBiogeographyImg;
        otherInfoBtn.image.sprite = unPressedotherInfoImg;
        youngStageBtn.image.sprite = unPressedyoungStageImg;
        middleStageBtn.image.sprite = unPressedmiddleStageImg;
        matureStageBtn.image.sprite = unPressedmatureStageImg;
        stageBtn.image.sprite = unPressedStageImg;
        infoBtn.image.sprite = pressedinfoImg;

    }

    public void ActiveBiogeoprahy()
    {
        biogeographyImage.SetActive(true);
        detailsImage.SetActive(false);
        otherInfoImage.SetActive(false);
        biogeographyBtn.image.sprite = pressedBiogeographyImg;
        detailsBtn.image.sprite = unPressedDetailsImg;
        otherInfoBtn.image.sprite = unPressedotherInfoImg;
        youngStageBtn.image.sprite = unPressedyoungStageImg;
        middleStageBtn.image.sprite = unPressedmiddleStageImg;
        matureStageBtn.image.sprite = unPressedmatureStageImg;
        stageBtn.image.sprite = unPressedStageImg;
        infoBtn.image.sprite = pressedinfoImg;
    }

    public void ActiveOtherInformation()
    {
        otherInfoImage.SetActive(true);
        biogeographyImage.SetActive(false);
        detailsImage.SetActive(false);
        otherInfoBtn.image.sprite = pressedotherInfoImg;
        biogeographyBtn.image.sprite = unPressedBiogeographyImg;
        detailsBtn.image.sprite = unPressedDetailsImg;
        youngStageBtn.image.sprite = unPressedyoungStageImg;
        middleStageBtn.image.sprite = unPressedmiddleStageImg;
        matureStageBtn.image.sprite = unPressedmatureStageImg;
        stageBtn.image.sprite = unPressedStageImg;
        infoBtn.image.sprite = pressedinfoImg;
    }







    // All the panels are below this
    public void ActiveStagesPanel()
    {
        if(stagesPanel.activeInHierarchy)
        {
            stagesPanel.SetActive(false);
            
            stageBtn.image.sprite = unPressedStageImg;
        }
        else
        {
            infoPanel.SetActive(false);
            stagesPanel.SetActive(true);
            stageBtn.image.sprite = pressedStageImg;
            infoBtn.image.sprite = unPressedinfoImg;
            otherInfoImage.SetActive(false);
            biogeographyImage.SetActive(false);
            detailsImage.SetActive(false);
        }
    }


    public void ActiveInfoPanel()
    {
        if (infoPanel.activeInHierarchy)
        {
            infoPanel.SetActive(false);
            otherInfoImage.SetActive(false);
            biogeographyImage.SetActive(false);
            detailsImage.SetActive(false);
            infoBtn.image.sprite = unPressedinfoImg;
        }
        else
        {
            stagesPanel.SetActive(false);
            infoPanel.SetActive(true);
            infoBtn.image.sprite = pressedinfoImg;
            stageBtn.image.sprite = unPressedStageImg;
        }
    }
}
