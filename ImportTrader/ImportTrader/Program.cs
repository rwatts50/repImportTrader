using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Data;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace ImportTrader
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            
            String choice;
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();

            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("-             EXPORT REPORTS TO EXCEL              -");
                Console.WriteLine("-                                                  -");
                Console.WriteLine("- Data will be exported to folder:                 -");
                Console.WriteLine("-               C:\\Import Trades\\Excel Reports\\    -");
                Console.WriteLine("-                                                  -");
                Console.WriteLine("-    Options:                                      -");
                Console.WriteLine("-    1. JAN                                        -");
                Console.WriteLine("-    2. FEB                                        -");
                Console.WriteLine("-    3. MAR                                        -");
                Console.WriteLine("-    4. APR                                        -");
                Console.WriteLine("-    5. MAY                                        -");
                Console.WriteLine("-    6. JUN                                        -");
                Console.WriteLine("-    7. JUL                                        -");
                Console.WriteLine("-    8. AUG                                        -");
                Console.WriteLine("-    9. SEP                                        -");
                Console.WriteLine("-    10. OCT                                       -");
                Console.WriteLine("-    11. NOV                                       -");
                Console.WriteLine("-    12. DEC                                       -");
                Console.WriteLine("----------------------------------------------------");
                
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                       startDate = new DateTime(DateTime.Today.Year, 1, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "2":
                       startDate = new DateTime(DateTime.Today.Year, 2, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "3":
                       startDate = new DateTime(DateTime.Today.Year, 3, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "4":
                       startDate = new DateTime(DateTime.Today.Year, 4, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "5":
                       startDate = new DateTime(DateTime.Today.Year, 5, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "6":
                       startDate = new DateTime(DateTime.Today.Year, 6, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "7":
                       startDate = new DateTime(DateTime.Today.Year, 7, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "8":
                       startDate = new DateTime(DateTime.Today.Year, 8, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "9":
                       startDate = new DateTime(DateTime.Today.Year, 9, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "10":
                       startDate = new DateTime(DateTime.Today.Year, 10, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "11":
                       startDate = new DateTime(DateTime.Today.Year, 11, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    case "12":
                       startDate = new DateTime(DateTime.Today.Year, 12, 1);
                       endDate = startDate.AddMonths(1).AddDays(-1);
                       process(startDate, endDate);
                       break;

                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }
            }
            while (choice != "0");
        }

        private static void process(DateTime startDate, DateTime endDate)
        {
            String path = String.Empty;
            List<DataSet> dsImported = new List<DataSet>();
            String importPath = @"C:\Import Trades\MT4 Reports\";
            String templatePath = Environment.CurrentDirectory + "\\";
            String defaultExportPath = @"C:\Import Trades\Excel Reports\";
            String templateFileName = "Template.xlsx";

            Console.WriteLine("Import Started...");
            dsImported = ImportFiles(importPath);
            Console.WriteLine("Cleaning Data...");
            dsImported = CleanDataDataTable(dsImported, startDate, endDate);
            dsImported = SplitCurrencies(dsImported);
            dsImported = IncludeCalculatedData(dsImported);
            Console.WriteLine("Export Started to " + defaultExportPath);
            Boolean res = ExportToExcel(dsImported, defaultExportPath, templatePath, templateFileName, startDate);
            if (res)
                Console.WriteLine("Import and Export Finished");
            else
                Console.WriteLine("Import Export Failed!");
        }

        private static List<DataSet> ImportFiles(String path)
        {
            List<DataSet> listDs = new List<DataSet>();
            String htmlCode = String.Empty;
            List<String> fileNames = new List<String>();

            //foreach (String s in Directory.GetFiles(path, "*.html").Select(Path.GetFileName))
                //fileNames.Add(s);

            foreach (String s in Directory.GetFiles(path, "*.htm").Select(Path.GetFileName))
                fileNames.Add(s);

            foreach (String filename in fileNames)
            {
                Boolean takeNext = false;
                DataTable data = new DataTable();
                DataTable balance = new DataTable();
                DataTable headerTable = new DataTable();
                DataSet ds = new DataSet();
                Int32 decInd = filename.IndexOf(".");
                ds.DataSetName = filename.Substring(0, decInd);
                FileStream fs = new FileStream(path + "\\" + filename, FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(fs);
                HtmlDocument doc = new HtmlDocument();

                htmlCode = r.ReadToEnd();

                doc.LoadHtml(htmlCode);

                foreach (var row in doc.DocumentNode.SelectNodes("//tr[td]"))
                {
                    if (row.InnerText.Contains("Account"))
                    {
                        var arr = row.SelectNodes("td").Select(td => td.InnerText).ToArray();
                        headerTable = new DataTable();
                        headerTable.TableName = "HeaderTable";
                        headerTable.Columns.Add("Col 1");
                        headerTable.Columns.Add("Col 2");
                        headerTable.Columns.Add("Col 3");
                        headerTable.Columns.Add("Col 4");
                        headerTable.Columns.Add("Col 5");
                        headerTable.Rows.Add(row.SelectNodes("td").Select(td => td.InnerText).ToArray());
                    }

                    else if (row.InnerText.Contains("Ticket") && (takeNext == false))
                    {
                        data = new DataTable();
                        data.TableName = "DataTable";
                        var arr = row.SelectNodes("td").Select(td => td.InnerText).ToArray();
                        foreach (String s in arr)
                        {
                            if (s == "Price" && data.Columns.Contains("Price"))
                            {
                                data.Columns.Add("Price2");
                            }
                            else
                            {
                                data.Columns.Add(s);
                            }
                        }
                        takeNext = true;
                    }
                    else if (row.InnerText.Contains("Balance") && (takeNext == true))
                    {
                        balance = new DataTable();
                        balance.TableName = "BalanceTable";
                        balance.Columns.Add("Col 1");
                        balance.Columns.Add("Col 2");
                        balance.Columns.Add("Col 3");
                        balance.Columns.Add("Col 4");
                        balance.Columns.Add("Col 5");
                        balance.Columns.Add("Col 6");
                        balance.Rows.Add(row.SelectNodes("td").Select(td => td.InnerText).ToArray());
                    }
                    else if (takeNext == true)
                    {
                        var arr = row.SelectNodes("td").Select(td => td.InnerText).ToArray();
                        data.Rows.Add(row.SelectNodes("td").Select(td => td.InnerText).ToArray());
                    }
                    else
                    {
                        Console.WriteLine("Unimported Text");
                        Console.WriteLine(row.InnerText);
                    }
                }
                ds.Tables.Add(headerTable);
                ds.Tables.Add(balance);
                ds.Tables.Add(data);

                listDs.Add(ds);
            }
            return listDs;
        }

        private static Boolean ExportToExcel(List<DataSet> dsExport, String defaultExportPath, String templatePath, String templateFileName, DateTime startDate)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(templatePath + templateFileName);

                if (File.Exists(templatePath + templateFileName))
                {
                    if (File.Exists(defaultExportPath + startDate.ToString("MMM") + "_Report.xlsx"))
                        wb.SaveAs(defaultExportPath + startDate.ToString("MMM") + "_Report_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");
                    else
                        wb.SaveAs(defaultExportPath + startDate.ToString("MMM") + "_Report.xlsx");

                    foreach (DataSet ds in dsExport)
                    {
                        DataTable dt = new DataTable();
                        
                        //Determine how many pairs or indecies have been traded with
                        int indeciesCount = 0;
                        List<String> IndeciesTableNames = new List<String>();
                        foreach (DataTable dsTable in ds.Tables)
                        {
                            indeciesCount += 1;
                            if (dsTable.TableName.Contains("DataTable"))
                                IndeciesTableNames.Add(dsTable.TableName.ToString());
                        }

                        foreach (String TableName in IndeciesTableNames)
                        {
                            //Excel.Worksheet sheet = wb.Sheets[ds.DataSetName];

                            Excel.Worksheet sheet = wb.Sheets.Add();

                            //Export Balance Info
                            foreach (DataTable dsTable in ds.Tables)
                            {
                                if (dsTable.TableName == "BalanceTable")
                                    dt = dsTable;
                            }

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                sheet.Cells[i + 1, "A"].Value2 = dt.Rows[i][1];
                                sheet.Cells[i + 1, "B"].Value2 += dt.Rows[i][2];
                                sheet.Cells[i + 1, "C"].Value2 += dt.Rows[i][3];
                                sheet.Cells[i + 1, "D"].Value2 += dt.Rows[i][4];
                                sheet.Cells[i + 1, "E"].Value2 += dt.Rows[i][5];
                            }

                            //Export Header Info
                            foreach (DataTable dsTable in ds.Tables)
                            {
                                if (dsTable.TableName == "HeaderTable")
                                    dt = dsTable;
                            }

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                sheet.Cells[i + 2, "A"].Value2 = dt.Rows[i][0];
                                sheet.Cells[i + 2, "B"].Value2 += dt.Rows[i][1];
                                sheet.Cells[i + 2, "C"].Value2 += dt.Rows[i][2];
                                sheet.Cells[i + 2, "D"].Value2 += dt.Rows[i][3];
                                sheet.Cells[i + 2, "E"].Value2 += dt.Rows[i][4];
                            }

                            //Export Data Info
                            foreach (DataTable dsTable in ds.Tables)
                            {
                                if (dsTable.TableName == TableName)
                                {
                                    dt = dsTable;
                                    int underscoreIndex = TableName.IndexOf("_");
                                    sheet.Name = ds.DataSetName + " " + TableName.Substring(underscoreIndex + 1);
                                }
                            }

                            //Export Data Column Header Info
                            for (int j = 1; j < dt.Columns.Count + 1; j++)
                            {
                                sheet.Cells[4, j] = dt.Columns[j - 1].ColumnName;
                            }

                            int rowIndex = 5;
                            //for (int i = 0; i < dt.Rows.Count; i++)
                            for (int i = dt.Rows.Count - 1; i >= 0; i--)
                            {
                                Excel.Range Line = (Excel.Range)sheet.Rows[5];
                                Line.Insert();

                                sheet.Cells[rowIndex, "A"].Value2 = dt.Rows[i][0];
                                sheet.Cells[rowIndex, "B"].Value2 += dt.Rows[i][1];
                                sheet.Cells[rowIndex, "C"].Value2 += dt.Rows[i][2];

                                if (dt.Rows[i][3] == DBNull.Value)
                                    sheet.Cells[rowIndex, "D"].Value2 += dt.Rows[i][3];
                                else if (dt.Rows[i][3].ToString() != "Deposit")
                                    sheet.Cells[rowIndex, "D"].Value2 = Convert.ToDecimal(dt.Rows[i][3].ToString().Replace(" ", String.Empty));

                                sheet.Cells[rowIndex, "E"].Value2 += dt.Rows[i][4];

                                if (dt.Rows[i][5] == DBNull.Value)
                                    sheet.Cells[rowIndex, "F"].Value2 += dt.Rows[i][5];
                                else
                                    sheet.Cells[rowIndex, "F"].Value2 = Convert.ToDecimal(dt.Rows[i][5].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][6] == DBNull.Value)
                                    sheet.Cells[rowIndex, "G"].Value2 += dt.Rows[i][6];
                                else
                                    sheet.Cells[rowIndex, "G"].Value2 = Convert.ToDecimal(dt.Rows[i][6].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][7] == DBNull.Value)
                                    sheet.Cells[rowIndex, "H"].Value2 += dt.Rows[i][7];
                                else
                                    sheet.Cells[rowIndex, "H"].Value2 = Convert.ToDecimal(dt.Rows[i][7].ToString().Replace(" ", String.Empty));

                                sheet.Cells[rowIndex, "I"].Value2 += dt.Rows[i][8];

                                if (dt.Rows[i][9] == DBNull.Value)
                                    sheet.Cells[rowIndex, "J"].Value2 += dt.Rows[i][9];
                                else
                                    sheet.Cells[rowIndex, "J"].Value2 = Convert.ToDecimal(dt.Rows[i][9].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][10] == DBNull.Value)
                                    sheet.Cells[rowIndex, "K"].Value2 += dt.Rows[i][10];
                                else
                                    sheet.Cells[rowIndex, "K"].Value2 = Convert.ToDecimal(dt.Rows[i][10].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][11] == DBNull.Value)
                                    sheet.Cells[rowIndex, "L"].Value += dt.Rows[i][11];
                                else
                                    sheet.Cells[rowIndex, "L"].Value2 = Convert.ToDecimal(dt.Rows[i][11].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][12] == DBNull.Value)
                                    sheet.Cells[rowIndex, "M"].Value2 += dt.Rows[i][12];
                                else
                                    sheet.Cells[rowIndex, "M"].Value2 = Convert.ToDecimal(dt.Rows[i][12].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][13] == DBNull.Value)
                                    sheet.Cells[rowIndex, "N"].Value2 += dt.Rows[i][13];
                                else
                                    sheet.Cells[rowIndex, "N"].Value2 = Convert.ToDecimal(dt.Rows[i][13].ToString().Replace(" ", String.Empty));

                                if (dt.Rows[i][14] == DBNull.Value)
                                    sheet.Cells[rowIndex, "O"].Value2 += dt.Rows[i][14];
                                else
                                    sheet.Cells[rowIndex, "O"].Value2 = Convert.ToDecimal(dt.Rows[i][14].ToString().Replace(" ", String.Empty));

                                //if (dt.Rows[i][15] == DBNull.Value)
                                //    sheet.Cells[rowIndex, "P"].Value2 += dt.Rows[i][15];
                                //else
                                //    sheet.Cells[rowIndex, "P"].Value2 = Convert.ToDecimal(dt.Rows[i][15].ToString().Replace(" ", String.Empty));
                            }

                            // get range of column to apply auto fit
                            var range = (Microsoft.Office.Interop.Excel.Range)(sheet.UsedRange.Columns);
                            range.AutoFit();

                            //Place account info at bottom of sheet
                            ReferenceData refData = new ReferenceData();
                            List<String> AccountInfo = refData.GetReferenceData(ds.DataSetName, dt.TableName);

                            if (AccountInfo != null && AccountInfo.Count > 0)
                            {
                                Int32 rowind = (dt.Rows.Count + 7);
                                foreach (String entry in AccountInfo)
                                {
                                    sheet.Cells[rowind, "A"].Value2 = entry;
                                    rowind += 1;
                                }
                            }

                            wb.Save();
                        }
                    }
                    Excel.Worksheet dummysheet = wb.Sheets["dummy"];
                    dummysheet.Delete();
                    wb.Save();
                }
                else
                {
                    Console.WriteLine("Template file doesn't exist");
                    return false;
                }

                wb.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Export Failed");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private static List<DataSet> CleanDataDataTable(List<DataSet> dsImported, DateTime startDate, DateTime endDate)
        {
            List<DataSet> result = new List<DataSet>();

            foreach (DataSet ds in dsImported)
            {
                DataSet dsResult = new DataSet();
                dsResult.DataSetName = ds.DataSetName;

                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.TableName == "HeaderTable")
                        dsResult.Tables.Add(dt.Copy());
                    else if (dt.TableName == "BalanceTable")
                        dsResult.Tables.Add(dt.Copy());
                    else if (dt.TableName == "DataTable")
                    {
                        DataTable newDataTable = new DataTable();

                        for (int i = dt.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dt.Rows[i];
                            Int32 intVal;
                            String val = dr[0].ToString();
                            if (!Int32.TryParse(val, out intVal) || (dr[10].ToString() == "cancelled") || (dr[2].ToString() == "balance"))
                            {
                                dr.Delete();
                            }
                            else if (dr[1] != DBNull.Value)
                            {
                                if (Convert.ToDateTime(dr[1]) < startDate || Convert.ToDateTime(dr[1]) > endDate)
                                {
                                    dr.Delete();
                                }
                            }
                        }
                        dt.AcceptChanges();
                        dsResult.Tables.Add(dt.Copy());
                    }
                }
                result.Add(dsResult);
            }
            return result;
        }

        private static List<DataSet> IncludeCalculatedData(List<DataSet> dsImported)
        {
            List<DataSet> result = new List<DataSet>();
            Decimal Balance = 0;
            Decimal sum = 0;
            foreach (DataSet ds in dsImported)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.TableName == "BalanceTable")
                    {
                        DataRow dr = dt.Rows[0];
                        String s = dr[1].ToString();
                        s = s.Replace(" ", string.Empty);
                        Balance = Convert.ToDecimal(s);
                    }

                    if (dt.TableName.Contains("DataTable"))
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["Profit"] != DBNull.Value)
                            {
                                String profit = dr["Profit"].ToString();
                                profit = profit.Replace(" ", string.Empty);
                                sum += Convert.ToDecimal(profit);
                            }
                        }
                        sum = Balance + sum;

                        DataColumn dcPip = new DataColumn();
                       // DataColumn dcBal = new DataColumn();
                        dcPip.ColumnName = "Pips";
                        //dcBal.ColumnName = "Running Balance";
                        dt.Columns.Add(dcPip);
                        //dt.Columns.Add(dcBal);

                        for (int i = dt.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dt.Rows[i];

                            if (dr["Type"].ToString() == "buy")
                            {
                                if (dr["Price"] != DBNull.Value && dr["Price2"] != DBNull.Value)
                                    dr["Pips"] = Convert.ToDecimal(dr["Price2"]) - Convert.ToDecimal(dr["Price"]);
                            }

                            else if (dr["Type"].ToString() == "sell")
                            {
                                if (dr["Price"] != DBNull.Value && dr["Price2"] != DBNull.Value)
                                    dr["Pips"] = Convert.ToDecimal(dr["Price"]) - Convert.ToDecimal(dr["Price2"]);
                            }

                            //if (dr["Profit"] != DBNull.Value)
                            //{
                            //    if (i != 0)
                            //    {
                            //        DataRow dr2 = dt.Rows[i - 1];
                            //        if (i == dt.Rows.Count - 1)
                            //            dr["Running Balance"] = sum;

                            //        dr2["Running Balance"] = Convert.ToDecimal(dr["Running Balance"]) - Convert.ToDecimal(dr["Profit"]);
                            //    }
                            //}
                        }

                        for (int i = dt.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dt.Rows[i];
                            int decPoint = dr["Price"].ToString().IndexOf(".");

                            if (decPoint > 2)
                            {
                                if (dr["Pips"] != DBNull.Value)
                                    dr["Pips"] = Convert.ToDecimal(dr["Pips"]);
                            }
                            else
                            {
                                if (dr["Pips"] != DBNull.Value)
                                    dr["Pips"] = Convert.ToDecimal(dr["Pips"]) * 10000;
                            }

                        }
                    }
                }
            }
            return dsImported;
        }

        private static List<DataSet> SplitCurrencies(List<DataSet> dsImported)
        {
            List<DataSet> result = new List<DataSet>();
            DataSet dsResult = new DataSet();

            for (int i = 0; i < dsImported.Count; i++)
            {
                dsResult = new DataSet();
                DataSet ds = dsImported[i];
                dsResult.DataSetName = ds.DataSetName;
                for (int x = 0; x < ds.Tables.Count; x++)
                {
                    DataTable daT = ds.Tables[x];
                    if (daT.TableName == "HeaderTable")
                        dsResult.Tables.Add(daT.Copy());
                    else if (daT.TableName == "BalanceTable")
                        dsResult.Tables.Add(daT.Copy());
                    else if (daT.TableName == "DataTable")
                        if (daT.TableName == "DataTable")
                        {
                            List<DataTable> dataTables = daT.AsEnumerable()
                            .GroupBy(row => row.Field<string>("Item"))
                            .Select(g => g.CopyToDataTable())
                            .ToList();

                            foreach (DataTable dataT in dataTables)
                            {
                                DataRow dataR = dataT.Rows[0];
                                dataT.TableName = "DataTable_" + dataR["Item"].ToString();
                                dsResult.Tables.Add(dataT);
                            }
                        }
                }
                result.Add(dsResult);
            }
            return result;
        }
    }
}