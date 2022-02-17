using UnityEngine;
using System.Net;
using System.IO;

 static class API{

    public static ClassJoke GetNewJoke(){
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chucknorris.io/jokes/random"); //criação da requisição
        HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //resposta da requisição
        StreamReader reader = new StreamReader(response.GetResponseStream()); //leitura da resposta
        string json = reader.ReadToEnd(); //passando a resposta para json
        return JsonUtility.FromJson<ClassJoke>(json); //retorna o json "processado"
    }
}
    