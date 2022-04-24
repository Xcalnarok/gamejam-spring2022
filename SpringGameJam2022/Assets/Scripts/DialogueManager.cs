using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Sprite carbonAngryImg;
    public Sprite carbonFlushedImg;
    public Sprite carbonHappyImg;
    public Sprite carbonNeutralImg;
    public Sprite carbonSadImg;

    public Sprite sodiumAngryImg;
    public Sprite sodiumFlushedImg;
    public Sprite sodiumHappyImg;
    public Sprite sodiumNeutralImg;
    public Sprite sodiumSadImg;

    public Sprite chlorineAngryImg;
    public Sprite chlorineFlushedImg;
    public Sprite chlorineHappyImg;
    public Sprite chlorineNeutralImg;
    public Sprite chlorineSadImg;

    public Sprite hydrogenAngryImg;
    public Sprite hydrogenFlushedImg;
    public Sprite hydrogenHappyImg;
    public Sprite hydrogenNeutralImg;
    public Sprite hydrogenSadImg;

    public GameObject left0Img;
    public GameObject left1Img;
    public GameObject left2Img;
    public GameObject centerImg;
    public GameObject right2Img;
    public GameObject right1Img;
    public GameObject right0Img;

    public GameObject savedPosition;
    public int expressionIndex;
    public int visibilityIndex;
    public int actorIndex;
    public List<List<Sprite>> actorList;
    public List<int> actorPosition;
    public List<GameObject> positionList;

    public struct PositionInfo
    {
        public int actorStatus;
        public int expressionStatus;
    }

    private void Awake()
    {
        List<Sprite> spriteList0 = new List<Sprite>();
        spriteList0.Add(hydrogenAngryImg);
        spriteList0.Add(hydrogenFlushedImg);
        spriteList0.Add(hydrogenHappyImg);
        spriteList0.Add(hydrogenNeutralImg);
        spriteList0.Add(hydrogenSadImg);

        List<Sprite> spriteList1 = new List<Sprite>();
        spriteList1.Add(chlorineAngryImg);
        spriteList1.Add(chlorineFlushedImg);
        spriteList1.Add(chlorineHappyImg);
        spriteList1.Add(chlorineNeutralImg);
        spriteList1.Add(chlorineSadImg);

        List<Sprite> spriteList2 = new List<Sprite>();
        spriteList2.Add(sodiumAngryImg);
        spriteList2.Add(sodiumFlushedImg);
        spriteList2.Add(sodiumHappyImg);
        spriteList2.Add(sodiumNeutralImg);
        spriteList2.Add(sodiumSadImg);

        List<Sprite> spriteList3 = new List<Sprite>();
        spriteList3.Add(carbonAngryImg);
        spriteList3.Add(carbonFlushedImg);
        spriteList3.Add(carbonHappyImg);
        spriteList3.Add(carbonNeutralImg);
        spriteList3.Add(carbonSadImg);

        actorList = new List<List<Sprite>>();
        actorList.Add(spriteList0);
        actorList.Add(spriteList1);
        actorList.Add(spriteList2);
        actorList.Add(spriteList3);

        actorPosition = new List<int>();
        actorPosition.Add(-1);
        actorPosition.Add(-1);
        actorPosition.Add(-1);
        actorPosition.Add(-1);
        actorPosition.Add(-1);
        actorPosition.Add(-1);
        actorPosition.Add(-1);

        positionList = new List<GameObject>();
        positionList.Add(left0Img);
        positionList.Add(left1Img);
        positionList.Add(left2Img);
        positionList.Add(centerImg);
        positionList.Add(right2Img);
        positionList.Add(right1Img);
        positionList.Add(right0Img);
    }

    public void clearAllPosition()
    {
        foreach (GameObject position in positionList)
        {
            position.SetActive(false);
        }
    }

    public void clearPosition(int p)
    {
        if (p >=0 && p<positionList.Count)
            positionList[p].SetActive(false);
    }

    public void savePosition(string positionStr)
    {
        switch(positionStr)
        {
            case "Left0":
                savedPosition = left0Img;
                break;
            case "Left1":
                savedPosition = left1Img;
                break;
            case "Left2":
                savedPosition = left2Img;
                break;
            case "Center":
                savedPosition = centerImg;
                break;
            case "Right2":
                savedPosition = right2Img;
                break;
            case "Right1":
                savedPosition = right1Img;
                break;
            case "Right0":
                savedPosition = right0Img;
                break;
        }
    }

    public int getPositionIndex(string positionStr)
    {
        switch (positionStr)
        {
            case "Left0":
                return 0;
            case "Left1":
                return 1;
            case "Left2":
                return 2;
            case "Center":
                return 3;
            case "Right2":
                return 4;
            case "Right1":
                return 5;
            case "Right0":
                return 6;
            case "All":
                return 7;
        }
        return -1;
    }

    public void saveActor(string actorStr)
    {
        switch(actorStr)
        {
            case "Hydrogen":
                actorIndex = 0;
                break;
            case "Chlorine":
                actorIndex = 1;
                break;
            case "Sodium":
                actorIndex = 2;
                break;
            case "Carbon":
                actorIndex = 3;
                break;
        }
    }

    public int getActorIndex(string actorStr)
    {
        switch (actorStr)
        {
            case "Hydrogen":
                return 0;
            case "Chlorine":
                return 1;
            case "Sodium":
                return 2;
            case "Carbon":
                return 3;
        }
        return -1;
    }

    public void saveExpression(string expressionStr)
    {
        switch(expressionStr)
        {
            case "Angry":
                expressionIndex = 0;
                break;
            case "Flushed":
                expressionIndex = 1;
                break;
            case "Happy":
                expressionIndex = 2;
                break;
            case "Neutral":
                expressionIndex = 3;
                break;
            case "Sad":
                expressionIndex = 4;
                break;
        }
    }

    public int getExpression(string expressionStr)
    {
        switch (expressionStr)
        {
            case "Angry":
                return 0;
            case "Flushed":
                return 1;
            case "Happy":
                return 2;
            case "Neutral":
                return 3;
            case "Sad":
                return 4;
        }
        return -1;
    }

    public void saveVisibility(string visibilityStr)
    {
        switch(visibilityStr)
        {
            case "1":
                visibilityIndex = 1;
                break;
            case "0":
                visibilityIndex = 0;
                break;
        }
    }

    public void setSavedActor()
    {
        if (actorIndex < 0 || actorIndex > 3) actorIndex = 0;
        if (expressionIndex < 0 || expressionIndex > 4) expressionIndex = 0;
        savedPosition.SetActive(true);
        savedPosition.GetComponent<Image>().sprite = actorList[actorIndex][expressionIndex];
    }

    public void setSavedActorTo(int x)
    {
        if (x < 0 || x > 6) return;
        if (actorIndex < 0 || actorIndex > 3) actorIndex = 0;
        if (expressionIndex < 0 || expressionIndex > 4) expressionIndex = 0;
        positionList[x].SetActive(true);
        positionList[x].GetComponent<Image>().sprite = actorList[actorIndex][expressionIndex];
    }

    public void setSavedPositionVisibility()
    {
        switch(visibilityIndex)
        {
            case 1:
                break;
            case 0:
                break;
        }
    }

    public void clearPreviousActor()
    {
        int previousIndex = findActor(actorIndex);
        clearPosition(previousIndex);
    }

    public int findActor(int actIndex)
    {
        for (int i = 0; i<actorPosition.Count;i++)
        {
            if(actorPosition[i] == actIndex)
            {
                return i;
            }
        }
        return -1;
    }

    public void moveSavedActor()
    {
        clearPreviousActor();
        setSavedActor();
    }

    public void moveSavedActorTo(int x)
    {
        clearPreviousActor();
        setSavedActor();
    }

    public void setPositionCmd(string actor, string position)
    {
        int ai = getActorIndex(actor);
        if (ai < 0 || ai > 3) return;
        int pi = getPositionIndex(position);
        int apos = findActor(ai);
        if (apos != -1) clearPosition(apos);
        saveActor(actor);
        setSavedActorTo(pi);
    }

    public void setExpressionCmd(string actor, string expression)
    {
        int ai = getActorIndex(actor);
        if (ai < 0 || ai > 3) return; 
        int ei = getExpression(expression);
        int apos = findActor(ai);
        if (apos != -1) clearPosition(apos);
        saveActor(actor);
        saveExpression(expression);
        setSavedActorTo(apos);
    }

    public void clearPositionCmd(string position)
    {
        int i = getPositionIndex(position);
        if (i == 7) //ALL
        {
            clearAllPosition();
        }
        else
        {
            clearPosition(i);
        }
    }

    public void setFocusCmd(string actor, string state)
    {

    }

    public void failedCmd()
    {

    }

    public void succeededCmd(string name, string description)
    {
        
    }
}
