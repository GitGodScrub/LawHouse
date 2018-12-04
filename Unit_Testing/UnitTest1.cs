using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess.Properties;
using Unit_Testing.Properties;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SqlConnectionTest() //Dennie 
        {
            string dbNavn = "goodboysplus1v2";
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnString))
            {
                Assert.AreEqual(dbNavn, conn.Database);
            }
        }

        [TestMethod]
        public void CheckSagIndex() //by Dennie
        {
            const string sqlString = "select * from Sag";

            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.Read())
                    {
                        Assert.IsNotNull(sqld[5]);
                    }
                }
            }
        }

        [TestMethod]
        public void CaseFillTest()
        {
            Sag @case = new Sag();
            @case.SagsNr = 1;
            @case.Arbejdstitel = "TheJob";
            @case.StartDato = "21-11-2018";
            @case.SlutDato = "22-11-2019";
            @case.Kørselstimer = "22";
            @case.TimeEstimat = "50";
            @case.SagsBeskrivelse = "Ezy Case bois";
            @case.InterneNoter = "not that ezy";
            @case.KlientNr = 2;
            @case.AdvokatId = 3;

        }
    }
}

