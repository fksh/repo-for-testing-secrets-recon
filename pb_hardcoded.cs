
class PUBLIC_KEY__HARDCODED

{
        private const string publicKey = "ApzdknBmkbpVA_PYZJJa9TT0hvTmUSQFKYyf1uyYoSwccUEYu7rfJpXTltrnBJD9";
        
        static void Main()
       
        {
            new X509Certificate2("certificate.pfx", "password");
        }
}
