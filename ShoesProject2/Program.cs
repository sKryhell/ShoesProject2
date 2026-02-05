namespace ShoesProject2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exotProgram = false;

            while (!exotProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formProducts = new FormProducts(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            if(formProducts.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exotProgram = true;
                            }
                        }
                    }else
                    {
                        exotProgram = true;    
                    }
                }
            }
        }
    }
}