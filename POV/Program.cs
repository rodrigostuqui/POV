using System;


namespace Question4
{
    public class POV
    {
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) 
            => (int)((totalNegociado * porcentagem) / (1 - porcentagem));
    }
}