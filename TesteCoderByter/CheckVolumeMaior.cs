namespace TesteESSPalindrome
{
    public static class CheckVolumeMaior
    {
        public static bool CheckNumeros(int[] numeros)
        {
            if (numeros.Length <= 0)
                return false;

            var numeroMaior = numeros.Max();
            numeros = numeros.Where(x => x != numeroMaior).ToArray();
            var numeroSomado = numeros.Sum();

            if (numeroMaior == numeroSomado)
                return true;
            else
            {
                var soma = 0;
                for (var i = numeros.Length - 1; i >= 0; i--)
                {
                    soma += numeros[i];
                    if (soma == numeroMaior)
                        return true;
                }
                soma = 0;
                for (var i = 0; i < numeros.Length; i++)
                {
                    soma += numeros[i];
                    if (soma == numeroMaior)
                        return true;
                }
            }
            
            return false;
        }
    }
}
