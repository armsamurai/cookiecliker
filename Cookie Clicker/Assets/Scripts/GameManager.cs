using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] long cookies = 0;
    long cookiesPerClick;
    long autoCookies;

    [SerializeField] int grandma = 0;
    [SerializeField] long grandmaCost = 100;

    [SerializeField] int bakery = 0;
    [SerializeField] long bakeryCost = 5000;

    [SerializeField] int factory = 0;
    [SerializeField] long factoryCost = 75000;

    [SerializeField] int city = 0;
    [SerializeField] long cityCost = 250000;

    [SerializeField] int portal = 0;
    [SerializeField] long portalCost = 750000;

    [SerializeField] int chocolate = 0;
    [SerializeField] long chocolateCost = 1000;

    [SerializeField] int apple = 0;
    [SerializeField] long appleCost = 10000;

    [SerializeField] int orange = 0;
    [SerializeField] long orangeCost = 150000;

    [SerializeField] int cherry = 0;
    [SerializeField] long cherryCost = 500000;

    [SerializeField] int blueberry = 0;
    [SerializeField] long blueberryCost = 1000000;

    [SerializeField] TextMeshProUGUI grandmaText;
    [SerializeField] TextMeshProUGUI bakeryText;
    [SerializeField] TextMeshProUGUI factoryText;
    [SerializeField] TextMeshProUGUI cityText;
    [SerializeField] TextMeshProUGUI portalText;
    [SerializeField] TextMeshProUGUI chocolateText;
    [SerializeField] TextMeshProUGUI appleText;
    [SerializeField] TextMeshProUGUI orangeText;
    [SerializeField] TextMeshProUGUI cherryText;
    [SerializeField] TextMeshProUGUI blueberryText;

    [SerializeField] TextMeshProUGUI cookiesText;
    [SerializeField] TextMeshProUGUI cookiesProfitText;
    [SerializeField] TextMeshProUGUI cookiesPerClickText;
    [SerializeField] TextMeshProUGUI autoCookiesText;
    [SerializeField] TextMeshProUGUI infoText;

    void Start()
    {
        StartCoroutine(AutoClicker());
    }

    
    void Update()
    {
        cookiesPerClick = grandma + bakery * 2 + factory * 50 + city * 150 + portal * 1000;
        autoCookies = chocolate * 2 + apple * 15 + orange * 100 + cherry * 1000 + blueberry * 2500;
        CookiesInfoTextProcess();
        UpgradesInfoTextProcess();
    }

    
    void CookiesInfoTextProcess()
    {
        cookiesText.text = cookies.ToString();
        cookiesProfitText.text = (cookiesPerClick + autoCookies).ToString();
        cookiesPerClickText.text = cookiesPerClick.ToString();
        autoCookiesText.text = autoCookies.ToString();
    }


    void UpgradesInfoTextProcess()
    {
        grandmaText.text = $"������\n���-��: {grandma}\n����: {grandmaCost}\n�����: {grandma}";
        bakeryText.text = $"�������\n���-��: {bakery}\n����: {bakeryCost}\n�����: {bakery*2}";
        factoryText.text = $"�������\n���-��: {factory}\n����: {factoryCost}\n�����: {factory*50}";
        cityText.text = $"����� �������\n���-��: {city}\n����: {cityCost}\n�����: {city*150}";
        portalText.text = $"�������-������\n���-��: {portal}\n����: {portalCost}\n�����: {portal*1000}";

        chocolateText.text = $"���������� ����\n���-��: {chocolate}\n����: {chocolateCost}\n�����: {chocolate*2}";
        appleText.text = $"�������� ����\n���-��: {apple}\n����: {appleCost}\n�����: {apple*15}";
        orangeText.text = $"������������ ����\n���-��: {orange}\n����: {orangeCost}\n�����: {orange*100}";
        cherryText.text = $"�������� ����\n���-��: {cherry}\n����: {cherryCost}\n�����: {cherry*1000}";
        blueberryText.text = $"��������� ����\n���-��: {blueberry}\n����: {blueberryCost}\n�����: {blueberry*2500}";
    }


    public void OneClick()
    {
        cookies += 1 + grandma + bakery * 2 + factory * 50 + city * 150 + portal * 1000;
    }


    IEnumerator AutoClicker()
    {
        while (true)
        {
            cookies += chocolate * 2 + apple * 15 + orange * 50 + cherry * 1000 + blueberry * 2500;
            yield return new WaitForSeconds(1f);
        }
    }


    public void BuyGrandma()
    {
        if (cookies >= grandmaCost)
        {
            cookies -= grandmaCost;
            grandmaCost = (int)(grandmaCost * 1.25);
            grandma += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else 
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {grandmaCost - cookies}";
        }
    }


    public void BuyBakery()
    {
        if (cookies >= bakeryCost)
        {
            cookies -= bakeryCost;
            bakeryCost = (int)(bakeryCost * 1.25);
            bakery += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {bakeryCost - cookies}";
        }
    }


    public void BuyFactory()
    {
        if (cookies >= factoryCost)
        {
            cookies -= factoryCost;
            factoryCost = (int)(factoryCost * 1.25);
            factory += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {factoryCost - cookies}";
        }
    }


    public void BuyCity()
    {
        if (cookies >= cityCost)
        {
            cookies -= cityCost;
            cityCost = (int)(cityCost * 1.25);
            city += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {cityCost - cookies}";
        }
    }


    public void BuyPortal()
    {
        if (cookies >= portalCost)
        {
            cookies -= portalCost;
            portalCost = (int)(portalCost * 1.25);
            portal += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {portalCost - cookies}";
        }
    }


    public void BuyChocolate()
    {
        if (cookies >= chocolateCost)
        {
            cookies -= chocolateCost;
            chocolateCost = (int)(chocolateCost * 1.25);
            chocolate += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {chocolateCost - cookies}";
        }
    }


    public void BuyApple()
    {
        if (cookies >= appleCost)
        {
            cookies -= appleCost;
            appleCost = (int)(appleCost * 1.25);
            apple += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {appleCost - cookies}";
        }
    }


    public void BuyOrange()
    {
        if (cookies >= orangeCost)
        {
            cookies -= orangeCost;
            orangeCost = (int)(orangeCost * 1.25);
            orange += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {orangeCost - cookies}";
        }
    }


    public void BuyCherry()
    {
        if (cookies >= cherryCost)
        {
            cookies -= cherryCost;
            cherryCost = (int)(cherryCost * 1.25);
            cherry += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {cherryCost - cookies}";
        }
    }


    public void BuyBlueberries()
    {
        if (cookies >= blueberryCost)
        {
            cookies -= blueberryCost;
            blueberryCost = (int)(blueberryCost * 1.25);
            blueberry += 1;
            infoText.text = "�����������! �� ������ ���������!";
        }
        else
        {
            infoText.text = $"� ���������, ��� �� ������� ������� ��� �������. ���������� ��������� ���: {blueberryCost - cookies}";
        }
    }


    public void Quit()
    {
        Application.Quit();
    }
}
