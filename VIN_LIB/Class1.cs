using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public  bool CheckVIN(string vin)
        {
            char[] vinSymb =
             {'0', '1', '2', '3', '4', '5', '6', '7', '8','9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T','U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] zapret = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'I', 'O', 'Q' };
            char[] zapretAll = { 'I', 'O', 'Q' };
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (vin.Length != 17)
            {
                return false;
            }

            for (int i = 0; i < 17; i++)
            {
                foreach(char c in zapretAll)
                {
                    if (vin[i] == c)
                        return false;
                }
            }
            //првоерка на WMI
            foreach (char c in zapret)
            {
                if (vin[0] == c)
                    return false;
                if (vin[1] == c)
                    return false;
               
            }

            

            //vis послед цифры
            
                //for (int i = 12; i < 16; i++)
                //{
                //    foreach(char j in num)
                //    {
                //      if (vin[i] == j)
                //        return false;
                //     }
                    
                //}
           

            return true;
        }
       public  string GetVINCountry(string vin)
         {
            int ind = -1;
            char[] vinSymb =
            {'0', '1', '2', '3', '4', '5', '6', '7', '8','9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T','U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < vinSymb.Length; i++)
            {
                
                if (vin[0] == vinSymb[i])
                {
                    ind = i;
                }
            }
            if (ind >= 1 && ind <= 5)
            {
                return "Северная Америка";
            }
            if (ind >= 6 && ind <= 7)
            {
                return "Океания";
            }
            if (ind >= 8 && ind <= 9)
            {
                return "Южная Америка";
            }
            if (ind >= 10 && ind <= 17)
            {
                return "Африка";
            }
            if (ind >= 18 && ind <= 24)
            {
                return "Азия";
            }
            if (ind >= 25 && ind <= 29)
            {
                return "Европа";
            }
         
            return "ошибка";
        }
    }

}
    


