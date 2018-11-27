using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextControl : MonoBehaviour {

    public Text title;

    List<string> questions = new List<string>() //{ "Capital city of Afghanistan?", "Capital city of Albania?", "Capital city of Algeria?", "Capital city of Andorra?", "Capital city of Angola?", "Capital city of Antigua and Barbuda?" };
        { "Capital city of Afghanistan?", "Capital city of Albania?", "Capital city of Algeria?", "Capital city of Andorra?", "Capital city of Angola?", "Capital city of Antigua and Barbuda?", "Capital city of Argentina?", "Capital city of Armenia?", "Capital city of Australia?", "Capital city of Austria?", "Capital city of Azerbaijan?", "Capital city of Bahamas?", "Capital city of Bahrain?", "Capital city of Bangladesh?", "Capital city of Barbados?", "Capital city of Belarus?", "Capital city of Belgium?", "Capital city of Belize?", "Capital city of Benin?", "Capital city of Bhutan?", "Capital city of Bolivia?", "Capital city of Bosnia and Herzegovina?", "Capital city of Botswana?", "Capital city of Brazil?", "Capital city of Brunei?", "Capital city of Bulgaria?", "Capital city of Burkina Faso?", "Capital city of Burundi?", "Capital city of Cabo Verde?", "Capital city of Cambodia?", "Capital city of Cameroon?", "Capital city of Canada?", "Capital city of Central African Republic?", "Capital city of Chad?", "Capital city of Chile?", "Capital city of China?", "Capital city of Colombia?", "Capital city of Comoros?", "Capital city of Democratic Republic of the Congo?", "Capital city of Republic of the Congo?", "Capital city of Costa Rica?", "Capital city of Cote d'Ivoire?", "Capital city of Croatia?", "Capital city of Cuba?", "Capital city of Cyprus?", "Capital city of Czech Republic?", "Capital city of Denmark?", "Capital city of Djibouti?", "Capital city of Dominica?", "Capital city of Dominican Republic?", "Capital city of Ecuador?", "Capital city of Egypt?", "Capital city of El Salvador?", "Capital city of Equatorial Guinea?", "Capital city of Eritrea?", "Capital city of Estonia?", "Capital city of Ethiopia?", "Capital city of Fiji?", "Capital city of Finland?", "Capital city of France?", "Capital city of Gabon?", "Capital city of Gambia?", "Capital city of Georgia?", "Capital city of Germany?", "Capital city of Ghana?", "Capital city of Greece?", "Capital city of Grenada?", "Capital city of Guatemala?", "Capital city of Guinea?", "Capital city of Guinea-Bissau?", "Capital city of Guyana?", "Capital city of Haiti?", "Capital city of Honduras?", "Capital city of Hungary?", "Capital city of Iceland?", "Capital city of India?", "Capital city of Indonesia?", "Capital city of Iran?", "Capital city of Iraq?", "Capital city of Ireland?", "Capital city of Israel?", "Capital city of Italy?", "Capital city of Jamaica?", "Capital city of Japan?", "Capital city of Jordan?", "Capital city of Kazakhstan?", "Capital city of Kenya?", "Capital city of Kiribati?", "Capital city of Kosovo?", "Capital city of Kuwait?", "Capital city of Kyrgyzstan?", "Capital city of Laos?", "Capital city of Latvia?", "Capital city of Lebanon?", "Capital city of Lesotho?", "Capital city of Liberia?", "Capital city of Libya?", "Capital city of Liechtenstein?", "Capital city of Lithuania?", "Capital city of Luxembourg?", "Capital city of Macedonia (FYROM)?", "Capital city of Madagascar?", "Capital city of Malawi?", "Capital city of Malaysia?", "Capital city of Maldives?", "Capital city of Mali?", "Capital city of Malta?", "Capital city of Marshall Islands?", "Capital city of Mauritania?", "Capital city of Mauritius?", "Capital city of Mexico?", "Capital city of Micronesia?", "Capital city of Moldova?", "Capital city of Monaco?", "Capital city of Mongolia?", "Capital city of Montenegro?", "Capital city of Morocco?", "Capital city of Mozambique?", "Capital city of Myanmar (Burma)?", "Capital city of Namibia?", "Capital city of Nauru?", "Capital city of Nepal?", "Capital city of Netherlands?", "Capital city of New Zealand?", "Capital city of Nicaragua?", "Capital city of Niger?", "Capital city of Nigeria?", "Capital city of North Korea?", "Capital city of Norway?", "Capital city of Oman?", "Capital city of Pakistan?", "Capital city of Palau?", "Capital city of Palestine?", "Capital city of Panama?", "Capital city of Papua New Guinea?", "Capital city of Paraguay?", "Capital city of Peru?", "Capital city of Philippines?", "Capital city of Poland?", "Capital city of Portugal?", "Capital city of Qatar?", "Capital city of Romania?", "Capital city of Russia?", "Capital city of Rwanda?", "Capital city of Saint Kitts and Nevis?", "Capital city of Saint Lucia?", "Capital city of Saint Vincent and the Grenadines?", "Capital city of Samoa?", "Capital city of San Marino?", "Capital city of Sao Tome and Principe?", "Capital city of Saudi Arabia?", "Capital city of Senegal?", "Capital city of Serbia?", "Capital city of Seychelles?", "Capital city of Sierra Leone?", "Capital city of Singapore?", "Capital city of Slovakia?", "Capital city of Slovenia?", "Capital city of Solomon Islands?", "Capital city of Somalia?", "Capital city of South Africa?", "Capital city of South Korea?", "Capital city of South Sudan?", "Capital city of Spain?", "Capital city of Sri Lanka?", "Capital city of Sudan?", "Capital city of Suriname?", "Capital city of Swaziland?", "Capital city of Sweden?", "Capital city of Switzerland?", "Capital city of Syria?", "Capital city of Taiwan?", "Capital city of Tajikistan?", "Capital city of Tanzania?", "Capital city of Thailand?", "Capital city of Timor-Leste?", "Capital city of Togo?", "Capital city of Tonga?", "Capital city of Trinidad and Tobago?", "Capital city of Tunisia?", "Capital city of Turkey?", "Capital city of Turkmenistan?", "Capital city of Tuvalu?", "Capital city of Uganda?", "Capital city of Ukraine?", "Capital city of United Arab Emirates?", "Capital city of United Kingdom?", "Capital city of United States of America?", "Capital city of Uruguay?", "Capital city of Uzbekistan?", "Capital city of Vanuatu?", "Capital city of Vatican City?", "Capital city of Venezuela?", "Capital city of Vietnam?", "Capital city of Yemen?", "Capital city of Zambia?", "Capital city of Zimbabwe?" };

    //List<string> world = new List<string>() { };
    //List<string> EU = new List<string>() { };


    List<string> correctAnswers = new List<string>() //{ "Kabul", "Tirana", "Algiers", "Andorra la Vella", "Luanda", "Saint John's" };
        { "Kabul", "Tirana", "Algiers", "Andorra la Vella", "Luanda", "Saint John's", "Buenos Aires", "Yerevan", "Canberra", "Vienna", "Baku", "Nassau", "Manama", "Dhaka", "Bridgetown", "Minsk", "Brussels", "Belmopan", "Porto-Novo", "Thimphu", "Sucre (de jure)", "Sarajevo", "Gaborone", "Brasilia", "Bandar Seri Begawan", "Sofia", "Ouagadougou", "Bujumbura", "Praia", "Phnom Penh", "Yaounde", "Ottawa", "Bangui", "N'Djamena", "Santiago", "Beijing", "Bogotá", "Moroni", "Kinshasa", "Brazzaville", "San Jose", "Yamoussoukro", "Zagreb", "Havana", "Nicosia", "Prague", "Copenhagen", "Djibouti ", "Roseau", "Santo Domingo", "Quito", "Cairo", "San Salvador", "Malabo (de jure)", "Asmara", "Tallinn", "Addis Ababa", "Suva", "Helsinki", "Paris", "Libreville", "Banjul", "Tbilisi", "Berlin", "Accra", "Athens", "Saint George's", "Guatemala City", "Conakry", "Bissau", "Georgetown", "Port-au-Prince", "Tegucigalpa", "Budapest", "Reykjavik", "New Delhi", "Jakarta", "Tehran", "Baghdad", "Dublin", "Jerusalem", "Rome", "Kingston", "Tokyo", "Amman", "Astana", "Nairobi", "Tarawa", "Pristina", "Kuwait City", "Bishkek", "Vientiane", "Riga", "Beirut", "Maseru", "Monrovia", "Tripoli", "Vaduz", "Vilnius", "Luxembourg ", "Skopje", "Antananarivo", "Lilongwe", "Kuala Lumpur", "Male", "Bamako", "Valletta", "Majuro", "Nouakchott", "Port Louis", "Mexico City", "Palikir", "Chisinau", "Monaco", "Ulaanbaatar", "Podgorica", "Rabat", "Maputo", "Naypyidaw", "Windhoek", "Yaren District (de facto)", "Kathmandu", "Amsterdam", "Wellington", "Managua", "Niamey", "Abuja", "Pyongyang", "Oslo", "Muscat", "Islamabad", "Ngerulmud", "Jerusalem (East)", "Panama City", "Port Moresby", "Asunción", "Lima", "Manila", "Warsaw", "Lisbon", "Doha", "Bucharest", "Moscow", "Kigali", "Basseterre", "Castries", "Kingstown", "Apia", "San Marino", "São Tomé", "Riyadh", "Dakar", "Belgrade", "Victoria", "Freetown", "Singapore", "Bratislava", "Ljubljana", "Honiara", "Mogadishu", "Pretoria (administrative)", "Seoul", "Juba", "Madrid", "Sri Jayawardenepura Kotte", "Khartoum", "Paramaribo", "Mbabane (administrative)", "Stockholm", "Bern", "Damascus", "Taipei", "Dushanbe", "Dodoma", "Bangkok", "Dili", "Lomé", "Nukuʻalofa", "Port of Spain", "Tunis", "Ankara", "Ashgabat", "Funafuti", "Kampala", "Kyiv (Kiev)", "Abu Dhabi", "London", "Washington, D.C.", "Montevideo", "Tashkent", "Port Vila", "Vatican City", "Caracas", "Hanoi", "Sana'a", "Lusaka", "Harare" };


    //List<string> worldCorrectAnswers;
    //List<string> EUCorrectAnswers;

    //storing randomnumber
    List<int> previousQuestions = new List<int>() { -1, -1, -1, -1 }; //placehold number just forget it
    public int questoinNumber = 0;

    public Text scoreText;
    public Text resultText;

    private int score;
    public int totalQuestions;

    public static string selectedAnswer;

    public static int randQuestion= -1;

    public static string choiceSelected = null;
	
	void Start ()
    {
        //if(StartGame.startGame.gameMode == 0)
        //{
        //    questions = world;
        //    correctAnswers = worldCorrectAnswers;
        //}

        //else if(StartGame.startGame.gameMode == 1)
        //{
        //    questions = EU;
        //    correctAnswers = EUCorrectAnswers;
        //}

        resultText.text = null;
	}

	void Update ()
    {
        if(randQuestion == -1)
        {
            randQuestion = Random.Range(0, questions.Count-1);

            for (int i = 0; i < previousQuestions.Count; i++)
            {
                if (randQuestion != previousQuestions[i])
                {

                }
                else
                {
                    randQuestion = -1;
                }
            }
        }


        if (randQuestion > -1)
        {
            title.text = questions[randQuestion];
            previousQuestions[questoinNumber] = randQuestion;
            previousQuestions.Add(randQuestion);
          
        }

        if(choiceSelected == "y")
        {
            choiceSelected = null;
            questoinNumber++;
            totalQuestions++;

            if (correctAnswers[randQuestion] == selectedAnswer)
            {
                resultText.text = "Correct, press next button";
                score++;
            }

            else
            {
                resultText.text = "Incorrect, try again or move to next question";   
            }

            scoreText.text = "Score: " + score + "  Total Questions: " + totalQuestions;
            StartCoroutine(ResetResultText());
        }
	}

    IEnumerator ResetResultText()
    {
        yield return new WaitForSeconds(3);
        resultText.text = null;
    }   
}
