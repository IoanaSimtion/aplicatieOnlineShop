using Application.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.user.service
{
    public class UserService
    {
        private List<User> users;

        public UserService()
        {

            users = new List<User>();

            this.load();

        }

        public void load()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);


            StreamReader streamReader = new StreamReader(parentDirectory.FullName+@"/data/users.txt");

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {

                switch (line.Split(",")[0])
                {

                    case "client":users.Add(new Client(line));
                        break;
                    case "admin": users.Add(new Admin(line));
                        break;

                }
            }


            streamReader.Close();
        }

        public void afisare()
        {
          
            for(int i = 0; i < users.Count; i++)
            {


                if (users[i] is Client)
                {

                    Client client = (Client)users[i];

                   Debug.WriteLine(client.descreiereClient());
                }
                else
                {
                    Admin admin = (Admin)users[i];

                    Debug.WriteLine(admin.descriereAdmin());
                }
            }
        }


        
    }
}
