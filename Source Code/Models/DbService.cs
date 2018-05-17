using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleLatex.Helper;

namespace StyleLatex.Models
{
    public class DbService
    {
        //string dataSource = @"Data Source=C:\Users\Anun Chaichomphoo\Documents\Visual Studio 2017\Projects\StyleLatex\db\db_stylelatex.db";
        string dataSource = @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"db\" + Constants.DbName;

        public List<DocOption> GetDocOptionData(string menuName)
        {
            DataTable dt = new DataTable();
            List<DocOption> result = new List<DocOption>();

            using (SQLiteConnection conn = new SQLiteConnection(dataSource))
            {
                conn.Open();
                string sql = "SELECT do.OptionName, do.OptionVal" +
                    " FROM Doc_Option do INNER JOIN  Doc_Menu dm" + " ON do.Menu_Id = dm.Menu_Id" +
                    $" AND dm.MenuName = '{menuName}';";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new DocOption() { name = row[0].ToString(), option = row[1].ToString() });
            }

            return result;
        }

        public List<string> GetEntryFieldData(string entry)
        {
            DataTable dt = new DataTable();
            List<string> result = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(dataSource))
            {
                conn.Open();
                string sql = "SELECT bf.FieldName" +
                            " FROM Bibtex_EntryField bef" +
                            $" INNER JOIN Bibtex_Entry be ON bef.Entry_Id = be.Entry_Id AND be.EntryName = '{entry}'" +
                            " INNER JOIN Bibtex_Field bf ON bef.Field_Id = bf.Field_Id; ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }

            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[0].ToString());
            }

            return result;
        } 

        public List<string> GetEntryData()
        {
            DataTable dt = new DataTable();
            List<string> result = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(dataSource))
            {
                conn.Open();
                string sql = "SELECT EntryName FROM Bibtex_Entry";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }

            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[0].ToString());
            }

            return result;
        }

        public List<string> GetFieldData()
        {
            DataTable dt = new DataTable();
            List<string> result = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(dataSource))
            {
                conn.Open();
                string sql = "SELECT FieldName FROM Bibtex_Field";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }

            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[0].ToString());
            }

            return result;
        }


    }
}
