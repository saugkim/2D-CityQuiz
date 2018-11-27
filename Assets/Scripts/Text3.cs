using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text3 : MonoBehaviour {

    public Text answerThirdText;

    List<string> thirdChoice = new List<string>() //{ "Pristina", "Abuja", "Cairo", "Addis Ababa", "Algiers", "Ngerulmud" };
        {"Pristina","Abuja","Cairo","Addis Ababa","Algiers","Ngerulmud","Buenos Aires","Andorra la Vella","Canberra","Antananarivo","Vilnius","Nassau","Manama","Astana","Asunción","Minsk","Baghdad","Baku","Nassau","Bandar Seri Begawan","Ljubljana","Sarajevo","Vienna","Brasilia","Bandar Seri Begawan","Sofia","Ouagadougou","Bujumbura","Abu Dhabi","Suva","Lomé","Ottawa","Bogotá","Sana'a","Kabul","Port of Spain","Bogotá","Dushanbe","Budapest","Brazzaville","Wellington","Cairo","Zagreb","Havana","Nicosia","Prague","Copenhagen","Dodoma","Dakar","Damascus","Podgorica","Conakry","Windhoek","Malabo (de jure)","Doha","Kuwait City","Addis Ababa","Freetown","Bissau","Nicosia","Georgetown","Kingstown","Khartoum","Harare","Havana","Athens","Honiara","Guatemala City","Copenhagen","Bishkek","Georgetown","Port-au-Prince","Kabul","Saint John's","Reykjavik","Khartoum","Kigali","Buenos Aires","Naypyidaw","Kinshasa","Kuala Lumpur","Taipei","Male","La Paz (seat of government)","Madrid","Addis Ababa","Lima","Lisbon","Beijing","Lomé","London","Moscow","Lusaka","Luxembourg ","Maseru","Monrovia","Tripoli","Dili","Managua","Luxembourg ","Tripoli","Panama City","Lilongwe","Kuala Lumpur","Mexico City","Minsk","Vaduz","Monaco","Nouakchott","Santiago","Moroni","Luanda","Warsaw","Monaco","Chisinau","Podgorica","Rabat","Funafuti","Naypyidaw","Windhoek","Seoul","Kathmandu","Nukuʻalofa","Wellington","Managua","Ouagadougou","Palikir","Pretoria (administrative)","Oslo","Muscat","Islamabad","Podgorica","Jerusalem (East)","Panama City","Tarawa","Jerusalem","Port-au-Prince","Porto-Novo","Algiers","Banjul","Pretoria (administrative)","Bucharest","Pyongyang","Quito","Port Vila","Reykjavik","Kingstown","Riyadh","San Marino","São Tomé","Saint George's","Nukuʻalofa","Belgrade","Victoria","Freetown","Sana'a","Santiago","Santo Domingo","São Tomé","Lisbon","Pretoria (administrative)","Singapore","Skopje","Sri Jayawardenepura Kotte","Sri Jayawardenepura Kotte","Stockholm","Sucre (de jure)","Suva","Stockholm","Tallinn","Tarawa","Tashkent","Dushanbe","Riyadh","Asunción","Dili","Tunis","Nukuʻalofa","Port of Spain","Tirana","La Paz (seat of government)","Ashgabat","Valletta","Kampala","Kyiv (Kiev)","Vienna","London","Vilnius","Phnom Penh","Tashkent","Wellington","Windhoek","Sarajevo","Yaounde","Sana'a","Yerevan","Harare"};

    //List<string> worldThird = new List<string>() { };
    //List<string> EUThird = new List<string>() { };

void Start()
    {
        //if (StartGame.startGame.gameMode == 0)
        //{
        //    thirdChoice = worldThird;
        //}

        //else if (StartGame.startGame.gameMode == 1)
        //{
        //    thirdChoice = EUThird;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            answerThirdText.text = thirdChoice[TextControl.randQuestion];
        }

    }

    public void ButtonClicked()
    {
        TextControl.choiceSelected = "y";
      //  TextControl.selectedAnswer = gameObject.GetComponent<Button>().name;
        TextControl.selectedAnswer = answerThirdText.text;
       
    }
}
