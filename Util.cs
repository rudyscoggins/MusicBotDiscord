using Newtonsoft.Json.Linq;

namespace MusicBotDiscord;
public class Util
{

private static readonly string dataLocation = "data/";

public static string GetTokenFromFile(){
    
    string json = System.IO.File.ReadAllText(@$"{dataLocation}credentials.json");

      // Parse the JSON string into a JObject
      JObject obj = JObject.Parse(json);
            
      return (string)obj["token"];

    
    //  You can assign your bot token to a string, and pass that in to connect.
    //  This is, however, insecure, particularly if you plan to have your code hosted in a public repository.
    //return "MTEwNTMyNzUzOTUyNzg4ODk0Nw.Gz60x7.bg1AUarJPMUBnx9d8gJsmCVilqOgrSTuUI4mXU";
}
}
