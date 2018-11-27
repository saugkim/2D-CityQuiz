using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text2 : MonoBehaviour {

    public Text answerSecondText;

    List<string> secondChoice = new List<string>() //{ "Kabul", "Yamoussoukro", "Algiers", "Apia", "Luanda", "Amman"};
        { "Kabul", "Yamoussoukro", "Algiers", "Apia", "Luanda", "Amman", "Tegucigalpa", "Yaounde", "Moroni", "Vienna", "Apia", "Damascus", "Asmara", "Maputo", "Antananarivo", "Vientiane", "Bucharest", "Belmopan", "Bamako", "Amman", "Sucre (de jure)", "Lima", "Basseterre", "London", "Nouakchott", "Bujumbura", "Belmopan", "Berlin", "Praia", "Phnom Penh", "Yaounde", "Bogotá", "Brasilia", "N'Djamena", "Santiago", "Bridgetown", "Rome", "Moroni", "Kinshasa", "Berlin", "Bujumbura", "Yamoussoukro", "Canberra", "Oslo", "Castries", "Port Moresby", "Juba", "Djibouti", "Prague", "Santo Domingo", "Dhaka", "Cairo", "San Salvador", "Athens", "Asmara", "Dublin", "Maseru", "Rabat", "Funafuti", "Paris", "Freetown", "Banjul", "Hanoi", "Berlin", "Victoria", "Helsinki", "Saint George's", "Islamabad", "Jakarta", "Jerusalem", "Asmara", "Juba", "Vatican City", "Kampala", "Kathmandu", "Ulaanbaatar", "Jakarta", "Kingston", "Baghdad", "Muscat", "Jerusalem", "Rome", "Kyiv (Kiev)", "Baghdad", "Amman", "Lilongwe", "Kinshasa", "Tarawa", "Ljubljana", "Belgrade", "Bishkek", "Luanda", "Yaren District (de facto)", "Mexico City", "Djibouti ", "Bamako", "Malabo (de jure)", "Vaduz", "Vilnius", "Manama", "Manila", "Maputo", "Maseru", "Reykjavik", "Porto-Novo", "Helsinki", "Valletta", "Majuro", "Monrovia", "Port Louis", "Mexico City", "Moscow", "Chisinau", "Dhaka", "Ulaanbaatar", "Naypyidaw", "N'Djamena", "Maputo", "Bangui", "Niamey", "Nicosia", "Nouakchott", "Amsterdam", "Ashgabat", "Ottawa", "Niamey", "Managua", "Panama City", "Palikir", "Jerusalem (East)", "Phnom Penh", "Ngerulmud", "Kyiv (Kiev)", "Bratislava", "Port of Spain", "Port Vila", "Gaborone", "Malabo (de jure)", "Warsaw", "Lisbon", "Doha", "Monaco", "Moscow", "Santo Domingo", "Rabat", "Castries", "Riga", "Apia", "Rome", "Roseau", "Sofia", "Dakar", "Niamey", "San Marino", "San Salvador", "Singapore", "Bratislava", "Ljubljana", "Honiara", "Mogadishu", "Seoul", "Minsk", "Juba", "Madrid", "Lilongwe", "Castries", "Canberra", "Mbabane (administrative)", "Taipei", "Kingston", "Accra", "Baku", "Tallinn", "Dodoma", "Tehran", "Thimphu", "Riga", "Bern", "Andorra la Vella", "Tunis", "Ulaanbaatar", "Praia", "Funafuti", "Vatican City", "Victoria", "Abu Dhabi", "Vientiane", "Tokyo", "Montevideo", "Abuja", "Port Vila", "Vatican City", "Yamoussoukro", "Hanoi", "Quito", "Washington, D.C.", "Zagreb" };

        //List<string> worldSecond = new List<string>() { };
        //List<string> EUSecond = new List<string>() { };


    void Start()
    {
        //if (StartGame.startGame.gameMode == 0)
        //{
        //    secondChoice = worldSecond;
        //}

        //else if (StartGame.startGame.gameMode == 1)
        //{
        //    secondChoice = EUSecond;
        //}
    }


    void Update()
    {
        if (TextControl.randQuestion > -1)
        {
            answerSecondText.text = secondChoice[TextControl.randQuestion];
        }

    }

    public void ButtonClicked()
    {
        TextControl.choiceSelected = "y";
      //  TextControl.selectedAnswer = gameObject.GetComponent<Button>().name;
         TextControl.selectedAnswer = answerSecondText.text;

    }
}

