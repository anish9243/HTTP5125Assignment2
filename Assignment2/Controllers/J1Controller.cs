using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<summary>
        ///Calculate the total calories of the meal at Chip's Fast Food emporium
        ///The user select a burgur , side order , drink, and dessert and the program calculate the total calories of that meal based on the selection of the user
        ///</summary>
        ///<param name="burger">The user's choice for the burger</param>
        ///<param name="drink">The user's choice for the drink</param>
        ///<param name="side">The user's choice for the sice</param>
        ///<param name="dessert">The user's choice for the dessert</param>
        ///<example>
        /// GET Localhost:xx/api/J1/Menu/{burger}/{drink}/{side}/{dessert} -> Your total calories is {}
        /// GET Localhost:xx/api/J1/Menu/4/4/4/4 -> Your total calories is 0
        /// </example>

            [HttpGet]
            [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
            public string Menu(int burger, int drink, int side, int dessert)
            {
                int[] burgerCalories = { 461, 431, 420, 0 }; // Calories for each burger option
                int[] drinkCalories = { 130, 160, 118, 0 }; // Calories for each drink option
                int[] sideCalories = { 100, 57, 70, 0 }; // Calories for each side option
                int[] dessertCalories = { 167, 266, 75, 0 }; // Calories for each dessert option

            if (burger > 0 && burger < 5 && drink > 0 && drink < 5 && side > 0 && side < 5 && dessert > 0 && dessert < 5)
            {

                int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];
                return "Your total calorie count is " + totalCalories;
            }
            return "Kindly choose the number between 1 to 4";
        }
    }
}
