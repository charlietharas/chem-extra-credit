using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonLevel : MonoBehaviour
{
    public void LoadLevelWithButton(string type) {
		System.Random random = new System.Random();
		string[] all_levels = {"Barium", "Calcium", "Magnesium", "Strontium", "Cadmium", "Hafnium", "Iron", "Mercury", "Molybdenum", "Nickel", "Osmium", "Palladium", "Titanium", "Tungsten", "Zinc", "Zirconium", "Dysprosium", "Erbium", "Gadolinium", "Neodymium", "Samarium", "Ytterbium", "Carbon", "Oxygen", "Selenium", "Silicon", "Sulfur", "Tellurium", "Germanium", "Lead", "Polonium", "Tin", "Argon", "Krypton", "Neon", "Radon", "Xenon"};
		string[] all_alkalines = {"Barium", "Calcium", "Magnesium", "Strontium"};
		string[] all_transitionmetals = {"Cadmium", "Hafnium", "Iron", "Mercury", "Molybdenum", "Nickel", "Osmium", "Palladium", "Titanium", "Tungsten", "Zinc", "Zirconium"};
		string[] all_lanthanoids = {"Dysprosium", "Erbium", "Gadolinium", "Neodymium", "Samarium", "Ytterbium"};
		string[] all_nonmetals = {"Carbon", "Oxygen", "Selenium", "Silicon", "Sulfur", "Tellurium"};
		string[] all_othermetals = {"Germanium", "Lead", "Polonium", "Tin"};
		string[] all_noblegases = {"Argon", "Krypton", "Neon", "Radon", "Xenon"};
		switch(type) {
			case "any": SceneManager.LoadScene(all_levels[random.Next(0, all_levels.Length)]); break;
			case "alkaline": SceneManager.LoadScene(all_alkalines[random.Next(0, all_alkalines.Length)]); break;
			case "transitionmetal": SceneManager.LoadScene(all_transitionmetals[random.Next(0, all_transitionmetals.Length)]); break;
			case "lanthanoid": SceneManager.LoadScene(all_lanthanoids[random.Next(0, all_lanthanoids.Length)]); break;
			case "nonmetal": SceneManager.LoadScene(all_nonmetals[random.Next(0, all_nonmetals.Length)]); break;
			case "othermetal": SceneManager.LoadScene(all_othermetals[random.Next(0, all_othermetals.Length)]); break;
			case "noblegas": SceneManager.LoadScene(all_noblegases[random.Next(0, all_noblegases.Length)]); break;
		}
	}
}
