using System;

namespace EscapeRoomAdventure {
   
    public class Server : ISystem {

            public Server(string status){
              Status = status;
            }

            public string Status
              {get; set;}

public void Operate(){
  Console.WriteLine($"Server is {Status}");
}

    }


}
