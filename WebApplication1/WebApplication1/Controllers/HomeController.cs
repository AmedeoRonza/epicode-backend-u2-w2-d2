using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsertCliente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertCliente(Cliente cliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "INSERT INTO Cliente (idCliente, Nominativo, IsAzienda, codiceFiscale, partitaIva) VALUES ( @idCliente, @Nominativo, @IsAzienda, @codiceFiscale, @partitaIva )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                cmd.Parameters.AddWithValue("@Nominativo", cliente.Nominativo);
                cmd.Parameters.AddWithValue("@IsAzienda", cliente.IsAzienda);
                cmd.Parameters.AddWithValue("@codiceFiscale", cliente.codiceFiscale ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@partitaIva", cliente.partitaIva ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("Errore");
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return View();
        }
    }
}