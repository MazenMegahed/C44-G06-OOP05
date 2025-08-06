namespace AssignmentOOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //1-a
            //2 - a
            //3 - b
            //4 - b
            //5 - d
            //6 - a
            //7 - b
            //8 - a
            //9 - b
            //10 - c
            #endregion

            #region part 2 -Q1
            //ICircle circle = new Circle();
            // circle.displayshapeinfo();
            // IRectangle rectangle = new Rectangle();
            // rectangle.displayshapeinfo();
            #endregion

            #region part2 -Q2
            AuthenticationService authenticationService = new AuthenticationService();
            authenticationService.mainusers = new User[2]; 
            authenticationService.mainusers[0] = new User
            {
                Username = "Ahmed",
                Password = "123456",
                Roles = new string[] { "auditor", "admin" }
            };
            authenticationService.mainusers[1] = new User
            {
                Username = "Khaled",
                Password = "888888",
                Roles = new string[] { "manager", "admin" }
            };
            Console.WriteLine("Enter details for User 1");
            Console.Write("Username: ");
            string username1 = Console.ReadLine();

            Console.Write("Password: ");
            string password1 = Console.ReadLine();

            List<string> roles=new List<string>();
            Console.Write("Enter User's role : ");
            roles.Add(Console.ReadLine());
           

            bool otherrole = false;
            do {
                Console.Write("Have this user other role ? yes/no : ");
                if (Console.ReadLine() == "yes")
                {
                    otherrole = true;
                    Console.Write("Enter Other Role : ");
                    {
                        roles.Add(Console.ReadLine());

                    }
                }
                else { otherrole = false; }


            }
            while (otherrole);
            bool authenticated = false ; bool Authorized = false ;
            foreach (var us in authenticationService.mainusers)
            {
                if (us.Username == username1 && us.Password == password1)
                {
                    authenticated = true;
                  
                        foreach (var role in roles) 
                        {
                        if (us.Roles.Contains(role.ToLower()))
                        {
                            Authorized = true;
                        }
                        else { Authorized = false; }

                        }
                    
                }
                
            }
            if (authenticated)
            {
                if (Authorized) { Console.WriteLine("Existed User and Authorized with allgiven roles"); }
                else
                {
                    Console.WriteLine("Existed User but not Authorized with allgiven roles");
                }
            }
            else { Console.WriteLine("Unexisted user"); }
            







            #endregion

        }
        interface IShape
        {
            public double Area { get; set; }
            public void displayshapeinfo();

        }
        interface ICircle : IShape
        {



        }
        interface IRectangle : IShape
        {

        }
        class Circle : ICircle
        {
            public double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void displayshapeinfo()
            {
                Console.WriteLine(  "This is Circle");            }
        }
        class Rectangle : IRectangle
        {
            public double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void displayshapeinfo()
            {
                Console.WriteLine(  "This is Rectangle");
            }
        }

        interface IAuthenticationService
        {
            public bool AuthorizeUser(string username, string password);
            public bool AuthenticateUser(string username, string password);
        }
        class AuthenticationService : IAuthenticationService
        {
            public User[] mainusers;
            public bool AuthenticateUser(string username, string password)
            {
                foreach (var user in mainusers)
                {
                    if (user.Username == username && user.Password == password)
                        return true;
                }
                return false;
            }

            public bool AuthorizeUser(string username, string role)
            {
                foreach (var user in mainusers)
                {
                    if (user.Username == username)
                    {
                        foreach (var r in user.Roles)
                        {
                            if (r == role)
                                return true;
                        }
                    }
                }
                return false;
            }
        }
    }

}
