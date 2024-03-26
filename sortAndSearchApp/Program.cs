namespace sortAndSearchApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SortandShow());
        }

        public static int[] Bsort(int[] vet)
        {
            int i, j, k = 0;

            for (i = 0;  i < vet.Length-1 ; i++) {
                for (j = 0;  j < vet.Length-(i+1) ; j++) {
                    if (vet[j] > vet[j + 1])
                    {
                        k = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j+1]=k;
                    }
                }
            }
            return vet;
        }
    }
}