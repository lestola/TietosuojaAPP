

/*------------------Vanha----------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace TietosuojaApp3
{
	public partial class Ohje : ContentPage
	{
		public Ohje()
		{
			InitializeComponent();
		}

		void json_DeSerialized_Clicked(object sender, System.EventArgs e)
		{
			string json = txtJSON.Text;

			Question kysymys1 = new Question();

			Newtonsoft.Json.JsonConvert.PopulateObject(json, kysymys1);

			txtQuestion.Text = kysymys1.kysymys;
			txtVastaus.Text = kysymys1.vastaus;



		}

		void json_Serialized_Clicked(object sender, System.EventArgs e)
		{
			Question kysymys1 = new Question();
			kysymys1.kysymys = txtQuestion.Text;
			kysymys1.vastaus = txtVastaus.Text;
			string content = JsonConvert.SerializeObject(kysymys1);
			txtJSON.Text = content;


		}
	}
}

--------------------toinen vanha---------------

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;


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
            string json = "{'kysymykset':[{'kysymys':'kuka oli presidenttinä','vastaus':'obama'},{'kysymys':'kuka on presidenttinä','vastaus':'trump'}]}";

            var resultObjects = AllChildren(JObject.Parse(json))
                .First(c => c.Type == JTokenType.Array && c.Path.Contains("kysymykset"))
                .Children<JObject>();

            foreach (JObject result in resultObjects)
            {

                foreach (JProperty property in result.Properties())
                {
                    


                }
            }
        }

        // recursively yield all children of json
        private static IEnumerable<JToken> AllChildren(JToken json)
        {
            foreach (var c in json.Children())
            {
                yield return c;
                foreach (var cc in AllChildren(c))
                {
                    yield return cc;
                }
            }
        }

        void json_DeSerialized_Clicked(object sender, System.EventArgs e)
        { }

    }
}






*/