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
        

        public Ohje()
        {
            InitializeComponent();

        }

        void json_Serialized_Clicked(object sender, System.EventArgs e)
        {
            
			Person person1 = new Person("Fred", 5);
			Person person2 = new Person("Molly", 13);
			object[] t = new object[2];
			t[0] = person1;
			t[1] = person2;

            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            //string json = JsonWriter.Serialize(t);
            // gives me the right string - [{"Name":"Fred","Age":5},{"Name":"Molly","Age":13}]
            txtJSON.Text = jsonData;

            Person[] jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Person[]>(jsonData);

			//foreach (var row in jsonObject)
            //    txtVastaus.Text = row.Name;

            txtQuestion.Text = jsonObject.ElementAt(0).Name;
            txtVastaus.Text = jsonObject.ElementAt(1).Name;

                


		
		}


        void json_DeSerialized_Clicked(object sender, System.EventArgs e)
        { 
            
        }

    }
}

