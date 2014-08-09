using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCore
{
    public class HackerRankCoreCls
    {
        public ArrayList ReadFile4Ints(string fPath)
        {
            ArrayList oAl = new ArrayList();
            try
            {
                string sLine = "";
                int iElem = 0;
                int i = 0;
                using (StreamReader oSr = new StreamReader(fPath))
                {
                    while ((sLine = oSr.ReadLine()) != null)
                    {
                        if (sLine.Trim() != "" && Int32.TryParse(sLine.Trim(), out iElem))
                        {
                            if (i >= 1)
                                oAl.Add(iElem);
                            i++;
                        }
                    }
                    if (oAl.Count!=i-1)
                        throw new Exception("Invalid input file!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oAl;

        }
    }
}
