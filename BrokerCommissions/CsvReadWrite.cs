using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokerCommissions
{
    //  Loads the Cases.CSV in datatable that Displays the gridview on the form.


    class CsvReadWrite
    {


        public DataTable CsvRead(string filename)
        {

            var sr = new StreamReader(new FileStream(filename, FileMode.Open));
            var csv = new CsvReader(sr);


            {

                csv.Read();
                csv.ReadHeader();

                Broker broker = new Broker();

                DataTable table = new DataTable();

                table.Columns.Add("Case ID", typeof(Int32));
                table.Columns.Add("Broker Name", typeof(string));
                table.Columns.Add("CaseValue", typeof(string));

                table.Columns.Add("Total commission in £", typeof(Decimal));
                table.Columns.Add("commission in £", typeof(Decimal));


                while (csv.Read())
                {

                    {
                        broker.CaseId = csv.GetField<Int32>("CaseId");
                        broker.BrokerName = csv.GetField<string>("BrokerName");
                        broker.CaseValue = csv.GetField<string>("CaseValue");

                        broker.TotalCommission = broker.BaseBonus;  // Total commission initial load is the same as the Base Bonus
                        table.Rows.Add(broker.CaseId, broker.BrokerName, broker.CaseValue, broker.TotalCommission, broker.BaseBonus);
                    }
                }
                return table;
            }
        }

       
    }
}
