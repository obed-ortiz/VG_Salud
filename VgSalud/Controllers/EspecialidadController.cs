using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VgSalud.Models;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;


namespace VgSalud.Controllers
{
    public class EspecialidadController : Controller
    {
        // GET: Especialidad
        public ActionResult RegistrarEspecialidad()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult RegistrarEspecialidad(E_Especialidades EEsp)
        {
            string Crea = Session["usuario"] + " " + DateTime.Now + " " + Environment.MachineName;

            using (SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["VG_SALUD"].ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd=new SqlCommand("usp_MtoEspecialidades", con))
                {
                    try
                    {
                        
                    cmd.Parameters.AddWithValue("@CodEspec", EEsp.CodEspec);
                    cmd.Parameters.AddWithValue("@NomEspec", EEsp.NomEspec.ToUpper());
                    cmd.Parameters.AddWithValue("@DescEspec", EEsp.DescEspec.ToUpper());
                    cmd.Parameters.AddWithValue("@EstEspec", EEsp.EstEspec);
                    cmd.Parameters.AddWithValue("@Crea", Crea);
                    cmd.Parameters.AddWithValue("@Modifica","");
                    cmd.Parameters.AddWithValue("@Elimina", "");
                    cmd.Parameters.AddWithValue("@Evento", 1);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        ViewBag.Mensaje = "Se registro Satisfactoriamente";
                    }
                    catch (Exception ex )
                    {
                        ViewBag.Mensaje = "Se registro Satisfactoriamente"+ex.Message.ToString();

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            return View(EEsp);
            }
          
        }


        public ActionResult ModificarEspecialidad(string Id)
        {
            var lista=(from x in ListadoEspecialidades() where x.CodEspec==Id select x).FirstOrDefault();
            return View(lista);
        }

        [HttpPost]
        public ActionResult ModificarEspecialida(E_Especialidades EEsp)
        {
            string Modificar = Session["usuario"] + " " + DateTime.Now + " " + Environment.MachineName;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VG_SALUD"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("usp_MtoEspecialidades", con))
                {
                    try
                    {

                        cmd.Parameters.AddWithValue("@CodEspec", EEsp.CodEspec);
                        cmd.Parameters.AddWithValue("@NomEspec", EEsp.NomEspec.ToUpper());
                        cmd.Parameters.AddWithValue("@DescEspec", EEsp.DescEspec.ToUpper());
                        cmd.Parameters.AddWithValue("@EstEspec", EEsp.EstEspec);
                        cmd.Parameters.AddWithValue("@Crea", "");
                        cmd.Parameters.AddWithValue("@Modifica", Modificar);
                        cmd.Parameters.AddWithValue("@Elimina", "");
                        cmd.Parameters.AddWithValue("@Evento", 2);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        ViewBag.Mensaje = "Se registro Satisfactoriamente";
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Mensaje = "Se registro Satisfactoriamente" + ex.Message.ToString();

                    }
                    finally
                    {
                        con.Close();
                    }
                }
                return View(EEsp);
            }

        }


        public ActionResult ListaEspecialidad()
        {
            return View(ListadoEspecialidades());
        }

        public List<E_Especialidades> ListadoEspecialidades()
        {
            List<E_Especialidades> Lista = new List<E_Especialidades>();
            using(SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["VG_SALUD"].ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd=new SqlCommand("Usp_Lista_Especialidades", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            E_Especialidades Esp = new E_Especialidades();

                            Esp.CodEspec = dr.GetString(0);
                            Esp.NomEspec = dr.GetString(1);
                            Esp.DescEspec = dr.GetString(2);

                            Lista.Add(Esp);
                        }
                        con.Close();
                    }
                    
                }
                return Lista;
            }
        }



    }
}