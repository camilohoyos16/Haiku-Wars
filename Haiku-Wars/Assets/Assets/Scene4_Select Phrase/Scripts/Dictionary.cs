using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Cards{	
	public class Dictionary : MonoBehaviour {

		private string[] pleasures= new string[6] ;
		private string[] phrases= new string[32] ;

		public Text [] textOfButtonesPhrases;
		public Text [] textOfBbuttonesPleasures;
		// Use this for initialization
		void Awake()
		{
			Pleasures ();
			Phrases ();
		}

		void Start () {
//			AssignButtons ();
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void Pleasures()
		{
			pleasures [0] = "Melancolía";
			pleasures [1] = "Comedia";
			pleasures [2] = "Tragedia";
			pleasures [3] = "Acción";
			pleasures [4] = "Terror";
			pleasures [5] = "Romance";			
		}

		void Phrases()
		{
			phrases [0] = "Nieve blanca";
			phrases [1] = "La oscuridad";
			phrases [2] = "League of legends";
			phrases [3] = "Perros y gatos";
			phrases [4] = "Leo tu gesto";
			phrases [5] = "Vida y muerte";
			phrases [6] = "En esta noche";
			phrases [7] = "Docenas de palomas";
			phrases [8] = "Solo aquí hoy";
			phrases [9] = "Hamburguesas";
			phrases [10] = "La triste verdad";
			phrases [11] = "Tus dedos encontrados";
			phrases [12] = "Vergas de queso";
			phrases [13] = "Entretenimiento digital";
			phrases [14] = "Videojuegos";
			phrases [15] = "Gato durmiente";
			phrases [16] = "Una aldea lejana";
			phrases [17] = "Festival de la vida";
			phrases [18] = "Peligros sin fin";
			phrases [19] = "En el frío";
			phrases [20] = "Dolor penetrante";
			phrases [21] = "Pedazos de mí";
			phrases [22] = "Verano se acerca";
			phrases [23] = "Noche de ensueño";
			phrases [24] = "Te esperaré";
			phrases [25] = "Mi alma perdida";
			phrases [26] = "Solo y cansado";
			phrases [27] = "Érase una vez";
			phrases [28]="Rosas son rojas";
			phrases [29] = "Galletas horneadas";
			phrases [30] = "El agua cae";
			phrases [31]="Calor veraniego";
		
		}

		/*void AssignButtons()
		{
			for (int i = 0; i <= 31; i++) {				
				textOfButtonesPhrases [i].text = phrases [i];
			}
		}*/

	}
}
