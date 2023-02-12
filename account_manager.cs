    
class PASSWORD__MANAGER

    {

      string password;
      string hash;
      

        static void Main()
        {
            if (password == "qwerty")

            {
                Console.WriteLine("your pass is correct!");
            }


            if (password.Equals("qwertyZ123456!"))
            
            {
                Console.WriteLine("your pass is correct!");
            }


            if (hash == "8743b52063cd84097a65d1633f5c74f5")

            {
                Console.WriteLine("your hash is correct");
            }


            if (password == "") {}

            if (password.Equals("")) {}
        }
    }


