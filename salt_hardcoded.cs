class CS_CRYPTO_SALT_HARDCODED

{
    static void Main()
    {
            Rfc2898DeriveBytes rdb = new Rfc2898DeriveBytes(password, "salt", 1000000);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, "salt", "sha256", 100000);
        }
}
