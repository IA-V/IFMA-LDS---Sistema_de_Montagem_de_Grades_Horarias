using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MontagemDeHorariosLabs
{
    public class Utils
    {
        public static bool verificaCPF(string cpf)
        {

            if (cpf.Length != 11)
            {
                return false;
            }

            int num1 = Int32.Parse(cpf.Substring(0,1));
            int num2 = Int32.Parse(cpf.Substring(1,1));
            int num3 = Int32.Parse(cpf.Substring(2,1));
            int num4 = Int32.Parse(cpf.Substring(3,1));
            int num5 = Int32.Parse(cpf.Substring(4,1));
            int num6 = Int32.Parse(cpf.Substring(5,1));
            int num7 = Int32.Parse(cpf.Substring(6,1));
            int num8 = Int32.Parse(cpf.Substring(7,1));
            int num9 = Int32.Parse(cpf.Substring(8,1));
            int num10 = Int32.Parse(cpf.Substring(9,1));
            int num11 = Int32.Parse(cpf.Substring(10,1));

            if ((num1 == num2) && (num2 == num3) && (num3 == num4) &&
                    (num4 == num5) && (num5 == num6) && (num6 == num7) &&
                    (num7 == num8) && (num8 == num9) && (num10 == num11))
            {
                return false;
            }
            else
            {
                int condicao1 = num1 * 10 + num2 * 9 + num3 * 8 + num4 * 7 + num5 * 6 + num6 * 5 + num7 * 4 + num8 * 3 + num9 * 2;
                double resto1 = (condicao1 * 10) % 11;
                if (resto1 == 10)
                {
                    resto1 = 0;
                }
                int condicao2 = num1 * 11 + num2 * 10 + num3 * 9 + num4 * 8 + num5 * 7 + num6 * 6 + num7 * 5 + num8 * 4 + num9 * 3 + num10 * 2;
                double resto2 = (condicao2 * 10) % 11;
                if (resto2 == 10)
                {
                    resto2 = 0;
                }
                if ((resto1 == num10) && (resto2 == num11))
                {
                    return true;
                }
                return false;
            }
        }

        public static string SHA256(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA256Managed SHhash = new SHA256Managed();
            string strHex = "";

            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }

        public static string extrairHorarioCompleto(string horario)
        {
            string[] horariosPossiveis = { "07:15 - 08:55", "08:55 - 10:35", "10:50 - 12:30", "13:10 - 14:50", "14:50 - 16:30" };
            string[] horariosEsperados = { "07:15 - 08:05", "08:05 - 08:55", "08:55 - 09:45", "09:45 - 10:35", "10:50 - 11:40", "11:40 - 12:30", "13:10 - 14:00", "14:00 - 14:50", "14:50 - 15:40", "15:40 - 16:30" };

            if (horario.Equals(horariosEsperados[0]))
                return horariosPossiveis[0];
            else if (horario.Equals(horariosEsperados[1]))
                return horariosPossiveis[0];
            else if (horario.Equals(horariosEsperados[2]))
                return horariosPossiveis[1];
            else if (horario.Equals(horariosEsperados[3]))
                return horariosPossiveis[1];
            else if (horario.Equals(horariosEsperados[4]))
                return horariosPossiveis[2];
            else if (horario.Equals(horariosEsperados[5]))
                return horariosPossiveis[2];
            else if (horario.Equals(horariosEsperados[6]))
                return horariosPossiveis[3];
            else if (horario.Equals(horariosEsperados[7]))
                return horariosPossiveis[3];
            else if (horario.Equals(horariosEsperados[8]))
                return horariosPossiveis[4];
            else if (horario.Equals(horariosEsperados[9]))
                return horariosPossiveis[4];
            else
                return null;
        }
    }
}
