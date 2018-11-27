using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Text1 : MonoBehaviour
{

    public Text answerFirstText;

    List<string> firstChoice = new List<string>() //{ "Abu Dhabi", "Tirana", "Accra", "Andorra la Vella", "Budapest", "Saint John's" };
        {"Abu Dhabi","Tirana","Accra","Andorra la Vella","Budapest","Saint John's","Amsterdam","Yerevan","Ankara","Guatemala City","Baku","Ashgabat","Luxembourg ","Dhaka","Bridgetown","Athens","Brussels","Brasilia","Porto-Novo","Thimphu","Bangkok","Banjul","Gaborone","Beijing","Beirut","Belgrade","Tunis","Kampala","Bern","Bishkek","Bissau","Manila","Bangui","Bratislava","Brazzaville","Beijing","Brussels","Bucharest","Ottawa","Buenos Aires","San Jose","New Delhi","Ankara","Caracas","Jakarta","Chisinau","Conakry","Copenhagen","Roseau","Doha","Quito","Dili","Djibouti ","Dodoma","Basseterre","Tallinn","Dushanbe","Suva","Helsinki","Gaborone","Libreville","Guatemala City","Tbilisi","Mogadishu","Accra","Yerevan","Pyongyang","Bandar Seri Begawan","Conakry","Bissau","Jerusalem (East)","Tbilisi","Tegucigalpa","Budapest","San Jose","New Delhi","Asmara","Tehran","Kingstown","Dublin","Dakar","Kuwait City","Kingston","Tokyo","Libreville","Astana","Nairobi","Mbabane (administrative)","Pristina","Kuwait City","São Tomé","Vientiane","Riga","Beirut","Madrid","Majuro","Paramaribo","Male","Dublin","N'Djamena","Skopje","Antananarivo","Harare","Mbabane (administrative)","Male","Bamako","Mogadishu","Bangkok","Majuro","Montevideo","Brazzaville","Palikir","Muscat","Nairobi","Nassau","Port Louis","Kigali","New Delhi","Ngerulmud","Caracas","Yaren District (de facto)","Manama","Hanoi","Oslo","Islamabad","Honiara","Abuja","Pyongyang","Paramaribo","Paris","Saint George's","Monrovia","Port Louis","Port Moresby","Port Moresby","Asunción","Lima","Manila","Prague","Praia","Kathmandu","Pristina","Bridgetown","Kigali","Basseterre","Valletta","Port-au-Prince","Sucre (de jure)","Zagreb","Tehran","Riyadh","Saint John's","San Jose","Tashkent","Belmopan","Kuala Lumpur","Sri Jayawardenepura Kotte","Ouagadougou","Beirut","Sarajevo","Singapore","Seoul","Roseau","Libreville","Sofia","Khartoum","Paramaribo","San Marino","Tirana","Bern","Damascus","Taipei","Tbilisi","Tegucigalpa","Bangkok","Astana","Lomé","Tokyo","Tripoli","Paris","Ankara","Vaduz","Nairobi","Montevideo","San Salvador","Skopje","Stockholm","Washington, D.C.","Warsaw","Washington, D.C.","Havana","Brussels","Caracas","Lusaka","Yaren District (de facto)","Lusaka","Thimphu"};
    
    //List<string> worldFist = new List<string>() { };
    //List<string> EUFirst = new List<string>() { };

   
    void Start ()
    {
        //if (StartGame.startGame.gameMode == 0)
        //{
        //    firstChoice = worldFist;
        //}

        //else if (StartGame.startGame.gameMode == 1)
        //{
        //    firstChoice = EUFirst;
        //}
    }


    void Update () {
        if(TextControl.randQuestion > -1)
        {
            answerFirstText.text = firstChoice[TextControl.randQuestion];
        }
		
	}

    public void ButtonClicked()
    {
        TextControl.choiceSelected = "y";
       // TextControl.selectedAnswer = gameObject.GetComponent<Button>().name;
        TextControl.selectedAnswer = answerFirstText.text;
        
    }
}


