using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Newtonsoft.Json;
using Echovoice.JSON;


namespace TietosuojaApp3
{

    public partial class Ohje : ContentPage
    {

        public static string jsonData;

        public Ohje()
        {
            InitializeComponent();

        }

        void json_Serialized_Clicked(object sender, System.EventArgs e)
        {
            
			Question person1 = new Question("Kuka on Suomen presidentti?", 3,"Kekkonen","Ahtisaari","Niinistö","Mannerheim");
			Question person2 = new Question("Mikä on seuraavista arvokkain metalli?", 2, "Hopea","Platina","Kulta","Kupari");
			object[] t = new object[2];
			t[0] = person1;
			t[1] = person2;

            jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            //string json = JsonWriter.Serialize(t);
            // gives me the right string - [{"Name":"Fred","Age":5},{"Name":"Molly","Age":13}]
            txtJSON.Text = jsonData;
		
		}


        void json_DeSerialized_Clicked(object sender, System.EventArgs e)
        {
			Question[] jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Question[]>(jsonData);

			//foreach (var row in jsonObject)
			//    txtVastaus.Text = row.Name;

			txtQuestion.Text = jsonObject.ElementAt(0).QuestionToAsk;
			txtVastaus.Text = jsonObject.ElementAt(1).QuestionToAsk;
        }

    }
}

