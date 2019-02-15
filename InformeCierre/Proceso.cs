using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Xml;
using log4net;


namespace InformeCierre
{



    public class Proceso
    {
        static ILog log = LogManager.GetLogger(typeof(Proceso));
        static string StrCon = ConfigurationManager.ConnectionStrings["strcon"].ToString();


        public static void prueba()
        {

            // string fecha = DateTime.Now.ToString();

            //var theDate = DateTime.ParseExact(fecha, "dd.MM.yyyy", CultureInfo.InvariantCulture);


            string Folder = ConfigurationManager.AppSettings["Folder"];
            log.Info("sddsdasdasdasdsadasds");

            //  static string fileName = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\myfile.txt";


            // var directorio2 = @"C:/Users/Nicolás Vega/Downloads/XMLdemo2/XMLdemo2/XMLdemo2/prueba/";

            var directorio2 = Folder;



            ColorOk("LINEA DE OK");
            // Console.WriteLine();

            ColorWarn("LINEA DE WARNING");
            //  Console.WriteLine();

            ColorError("LINEA DE ERRORES");
            //Console.WriteLine();

            ColorOk(directorio2);

            log.InfoFormat("Lyendo el directorio {0}", directorio2);

            //  Console.WriteLine();
            // Console.ResetColor();

            // var directorio = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\otro\";

            string[] files2 = Directory.GetDirectories(directorio2);

            //List<string> carpeta = new List<string>();



            for (int iFile = 0; iFile < files2.Length; iFile++)
            {
                string fn = new FileInfo(files2[iFile]).Name;

                string carpeta = directorio2 + fn + "/";
                // carpeta.Add(directorio2 + fn);
                string[] files3 = Directory.GetDirectories(carpeta);

                for (int iFile3 = 0; iFile3 < files3.Length; iFile3++)
                {
                    string fn3 = new FileInfo(files3[iFile3]).Name;

                    string carpetas = directorio2 + fn + "/" + fn3 +"/";
                    // carpeta.Add(directorio2 + fn);


                    string[] files = Directory.GetFiles(carpetas);


                List<string> list = new List<string>();

                var i = 0;
                for (int iFile2 = 0; iFile2 < files.Length; iFile2++)
                {
                    string fn2 = new FileInfo(files[iFile2]).Name;
                    list.Add(carpetas + fn2);

                }


                //   var caso1 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.cierre_sucursal.xml";

                //  var caso2 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.fmlr_cheque.xml";

                //  var caso3 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.fmlr_obligacion.xml";

                // var caso4 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.nota_obligacion.xml";

                //  var caso5 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.transaccion.xml";





                //var caso1 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.cierre_sucursal.xml";

                //var caso2 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.fmlr_cheque.xml";

                //var caso3 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.fmlr_obligacion.xml";

                //var caso4 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.nota_obligacion.xml";

                //var caso5 = @"C:\Users\Nicolás Vega\Downloads\XMLdemo2\XMLdemo2\XMLdemo2\ConBan330Ane0330Cie00052237ProtectedInfo.transaccion.xml";

                //List<string> list = new List<string>();

                //list.Add(caso1);
                //list.Add(caso2);
                //list.Add(caso3);
                //list.Add(caso4);
                //list.Add(caso5);






                foreach (var pair in list)
                {



                    string XMlFile = pair;
                    if (File.Exists(XMlFile))
                    {

                        DataTable dt = XMLSQL(XMlFile);
                        if (dt.Columns.Count == 0)
                            dt.ReadXml(XMlFile);
                        ColorProceso("Procesando " + XMlFile);
                        log.InfoFormat("Procesando {0}", XMlFile);
                        string Query = prueba(dt);



                        //  string StrCon = ConfigurationManager.ConnectionStrings["strcon"].ToString();
                        //SqlCommand comm = new SqlCommand();
                        //comm.Connection = new SqlConnection(StrCon);
                        //String sql = @"  SELECT TRANSACCION_ID, IMPUESTO, SECSEC, CONCEPTO, SUBCONCEPTO, PERIODO_FISCAL, ANTICIPO_CUOTA, MONTO_INGRESADO FROM fmlr_obligacion";

                        //comm.CommandText = sql;
                        //comm.Connection.Open();

                        //SqlDataReader sqlReader = comm.ExecuteReader();

                        //// Change the Encoding to what you need here (UTF8, Unicode, etc)
                        //using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, false, Encoding.UTF8))
                        //{
                        //    while (sqlReader.Read())
                        //    {
                        //        writer.WriteLine(sqlReader["TRANSACCION_ID"] + "\t" + sqlReader["IMPUESTO"]);
                        //    }
                        //}

                        //sqlReader.Close();
                        //comm.Connection.Close();



                    }

                }

                




            }

                var fechas = DateTime.Now;
                var fecha = fechas.ToString("ddmmyyyyhhmmss");

                if (fn == "330")
                {
                    ColorOk("Los datos se registraron correctamente 330.");
                    log.Info("Los datos se registraron correctamente 330.");
                    string banco = "330";


                    string fileName = @"C:\Users\Nicolás Vega\Documents\Osiris_" + fecha + ".txt";
                    ColorOk("Se crea el archivo Osiris.txt");
                    log.Info("Se crea el archivo Osiris.txt");
                    EscribirTxt(fileName, banco);

                }
                else
                {

                    ColorOk("Los datos se registraron correctamente 065.");
                    string banco = "065";
                    string fileName = @"C:\Users\Nicolás Vega\Documents\OsirisO_" + fecha + ".txt";
                    ColorOk("Se crea el archivo OsirisO.txt");
                    EscribirTxt(fileName, banco);

                }

            }
    }



        public static string prueba(DataTable dt)
        {
            if (dt.TableName == "transaccionQQ")
            {
                string Query = CrearTablaSQL(dt);
                SqlConnection con = new SqlConnection(StrCon);
                con.Open();

                // BORRAMOS LA TABLA SI EXISTE
                SqlCommand cmd =
                    new SqlCommand(
                        "IF OBJECT_ID('dbo." + dt.TableName + "', 'U') IS NOT NULL DROP TABLE dbo." + dt.TableName +
                        ";", con);
                cmd.ExecuteNonQuery();

                // CREA LA TABLA
                cmd = new SqlCommand(Query, con);
                int check = cmd.ExecuteNonQuery();
                if (check != 0)
                {
                    // DEL DATATABLE AL SQL
                    using (var bulkCopy = new SqlBulkCopy(con.ConnectionString, SqlBulkCopyOptions.KeepIdentity))
                    {

                        try
                        {
                            foreach (DataColumn col in dt.Columns)
                            {
                                bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                            }

                            bulkCopy.BulkCopyTimeout = 600;
                            bulkCopy.DestinationTableName = dt.TableName;
                            bulkCopy.WriteToServer(dt);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.ToString());
                        }



                    }
                }
                con.Close();
                return null;
            }

            else
            {

                //string Query = CrearTablaSQL(dt);
                SqlConnection con = new SqlConnection(StrCon);
                con.Open();
                //ColorOk("Se establece conexion con la base");

                //// BORRAMOS LA TABLA SI EXISTE
                //SqlCommand cmd =
                //    new SqlCommand(
                //        "IF OBJECT_ID('dbo." + dt.TableName + "', 'U') IS NOT NULL TRUNCATE TABLE dbo." + dt.TableName +
                //        ";", con);

                //ColorProceso("Se borran los registros de la tabla " + dt.TableName);
                //cmd.ExecuteNonQuery();

                //// CREA LA TABLA
                ////  cmd = new SqlCommand(Query, con);
                //int check = cmd.ExecuteNonQuery();
                //if (check != 0)
                //{
                    // DEL DATATABLE AL SQL
                    using (var bulkCopy = new SqlBulkCopy(con.ConnectionString, SqlBulkCopyOptions.KeepIdentity))
                    {

                        try
                        {
                            foreach (DataColumn col in dt.Columns)
                            {
                                bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                            }

                            bulkCopy.BulkCopyTimeout = 600;
                            bulkCopy.DestinationTableName = dt.TableName;
                            bulkCopy.WriteToServer(dt);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.ToString());
                        }



                    }
             //   }
                con.Close();
                return null;
            }

        }


        // NOMBRE PARA LA TABLA, REEMPLAZO Y ACORTO EL NOMBRE
        public static string ObtenerNombreTabla(string file)
        {
            FileInfo fi = new FileInfo(file);
            string TableName = fi.Name.Replace(fi.Extension, "");
            //string prueba = TableName.Remove(0, 41);

            string cadena = TableName;

            string nombresolo = cadena.Split('.')[1];

            // int cantidad = parte.Length;


            string tabla = nombresolo; // TableName.Replace("ConBan330Ane0330Cie00021056ProtectedInfo.", "");

            return tabla;
        }

        // CON ESTO CREO LA TABLA
        public static string CrearTablaSQL(DataTable table)
        {
            string sqlsc = "CREATE TABLE " + table.TableName + "(";
            // progressBar1.Maximum = table.Columns.Count;
            //   progressBar1.Value = 0;
            table.Columns.Add("Id");
            for (int i = 0; i < table.Columns.Count; i++)
            {
                sqlsc += "[" + table.Columns[i].ColumnName + "]";
                string columnType = table.Columns[i].DataType.ToString();
                switch (columnType)
                {
                    case "System.Int32":
                        sqlsc += " int ";
                        break;
                    case "System.Int64":
                        sqlsc += " bigint ";
                        break;
                    case "System.Int16":
                        sqlsc += " smallint";
                        break;
                    case "System.Byte":
                        sqlsc += " tinyint";
                        break;
                    case "System.Decimal":
                        sqlsc += " decimal ";
                        break;
                    case "System.DateTime":
                        sqlsc += " datetime ";
                        break;
                    case "System.String":
                    default:
                        sqlsc += string.Format(" nvarchar({0}) ",
                            table.Columns[i].MaxLength == -1 ? "max" : table.Columns[i].MaxLength.ToString());
                        break;
                }
                if (table.Columns[i].AutoIncrement)
                    sqlsc += " IDENTITY(" + table.Columns[i].AutoIncrementSeed.ToString() + "," +
                             table.Columns[i].AutoIncrementStep.ToString() + ") ";
                if (!table.Columns[i].AllowDBNull)
                    sqlsc += " NOT NULL ";
                sqlsc += ",";

                //Progress();
            }
            return sqlsc.Substring(0, sqlsc.Length - 1) + "\n)";
        }

        // SE CONVIERTE EL XML A SQL
        public static DataTable XMLSQL(string XmlFile)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(XmlFile);

            ColorProceso("Inicio insertar datos de XML a SQL");

            DataTable Dt = new DataTable();

            try
            {
                Dt.TableName = ObtenerNombreTabla(XmlFile);
                XmlNode NodoEstructura = doc.DocumentElement.ChildNodes.Cast<XmlNode>().ToList()[0];
                //  progressBar1.Maximum = NodoEstructura.ChildNodes.Count;
                // progressBar1.Value = 0;
                foreach (XmlNode columna in NodoEstructura.ChildNodes)
                {
                    Dt.Columns.Add(columna.Name, typeof(String));
                    //  Progress();
                }

                XmlNode Filas = doc.DocumentElement;
                //    progressBar1.Maximum = Filas.ChildNodes.Count;
                // progressBar1.Value = 0;
                foreach (XmlNode Fila in Filas.ChildNodes)
                {
                    List<string> Valores = Fila.ChildNodes.Cast<XmlNode>().ToList().Select(x => x.InnerText).ToList();
                    Dt.Rows.Add(Valores.ToArray());
                    //  Progress();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            return Dt;
        }

        // BARRA DE PROGRESO
        //public static void Progress()
        //{
        //    if (progressBar1.Value < progressBar1.Maximum)
        //    {
        //        progressBar1.Value++;
        //        int percent = (int) (((double) progressBar1.Value/(double) progressBar1.Maximum)*100);
        //        progressBar1.CreateGraphics()
        //            .DrawString(percent.ToString() + "%", new Font("Arial", (float) 8.25, FontStyle.Regular),
        //                Brushes.Black, new PointF(progressBar1.Width/2 - 10, progressBar1.Height/2 - 7));

        //        Application.DoEvents();
        //    }
        //}



        public static void Ejecutarsp( string banco)
        {

            string StrCon = ConfigurationManager.ConnectionStrings["strcon"].ToString();

            SqlCommand cmd = new SqlCommand("dbo.ActalizarInformedos", new SqlConnection(StrCon));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Banco", banco));
            ColorProceso("Se inicializa SP ActalizarInforme");

            cmd.Connection.Open();


            SqlDataReader sqlReader2 = cmd.ExecuteReader();
            ColorProceso("Se ejecuta SP ActalizarInforme");
            cmd.Connection.Close();

            return;

        }




        public static void EscribirTxt(string fileName, string banco)
        {

            string StrCon = ConfigurationManager.ConnectionStrings["strcon"].ToString();
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(StrCon);



            String sql =
                @"SELECT MONEDA, BANCO, CIERRE_BANCO, FECHA_CIERRE, SUCURSAL, TIPO_SUCURSAL, TRANSACCION, FECHA_PROCESO, TIPO_OPERACION, CIERRE_SUCURSAL, CREDITO, COMISION_X_TRAN,
    COMISION_RECAUD, FORMULARIO, CUIT, USUARIO, PUESTO, FECHA_ANULACION, FORMA_PAGO, BANCO_CHEQUE, SUCURSAL_CHEQUE, NUMERO_CHEQUE, IMPUESTO, IVA,
    RETENCION_IVA  FROM hola2";

//            String sql =
//                @" SELECT TRANSACCION_ID, CIERRE_BANCO, BANCO, TIPO_SUCURSAL, SUCURSAL, TRANSACCION, CIERRE_SUCURSAL, FORMA_PAGO, TIPO_OPERACION, USUARIO, PUESTO, FORMULARIO, VERSION, VERIFICADOR, FECHA_REGISTRO, FECHA_CIERRE,
//FECHA_PROCESO, CREDITO, COMISION_X_TRAN, COMISION_RECAUD, BANCO_CHEQUE, SUCURSAL_CHEQUE, NUMERO_CHEQUE, CUIT, ESTABLECIMIENTO, CANT_ERROR, CANT_DETALLE, CANT_CAMPO, CANT_PAGO, CANT_OBLIGACION, CANT_CHEQUE,
//TOTAL_MONTO_INGRESADO, COD_CONTROL, COD_CONTROL_AFIP, ENTIDAD_DE_PAGO, IVA, RETENCION_IVA FROM dbo.informe";


         
            Ejecutarsp(banco);


           

            comm.CommandText = sql;
            comm.Connection.Open();


            SqlDataReader sqlReader = comm.ExecuteReader();


            ColorProceso("Se Inertan los datos en el archivo txt");

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, false, Encoding.UTF8))
            {
                while (sqlReader.Read())
                {

                  
                    //  DateTime.ParseExact(sqlReader["fecha"], "MM-dd-yyyy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture)
                    writer.WriteLine(sqlReader["MONEDA"] + sqlReader["BANCO"].ToString() +
                        sqlReader["CIERRE_BANCO"] + sqlReader["FECHA_CIERRE"] +
                        sqlReader["SUCURSAL"] + sqlReader["TIPO_SUCURSAL"] +
                        sqlReader["TRANSACCION"] + sqlReader["FECHA_PROCESO"] +
                        sqlReader["TIPO_OPERACION"] + sqlReader["CIERRE_SUCURSAL"]+
                        sqlReader["CREDITO"] + sqlReader["COMISION_X_TRAN"] +
                        sqlReader["COMISION_RECAUD"] + sqlReader["FORMULARIO"] +

                         sqlReader["CUIT"] + sqlReader["USUARIO"] +
                          sqlReader["PUESTO"] + sqlReader["FECHA_ANULACION"] + "\t\t" +
                           sqlReader["FORMA_PAGO"] + sqlReader["BANCO_CHEQUE"] +
                            sqlReader["SUCURSAL_CHEQUE"] + sqlReader["NUMERO_CHEQUE"] +
                             sqlReader["IMPUESTO"] + sqlReader["IVA"]+
                                     // sqlReader["TRANSACCION_ID"] + "\t" + sqlReader["SUCURSAL"] +
                                     sqlReader["RETENCION_IVA"]);


                    // writer.WriteLine(sqlReader["n.BANCO"].ToString() + sqlReader["n.CIERRE_BANCO"].ToString() + sqlReader["n.FECHA_CIERRE"].ToString() + sqlReader["n.SUCURSAL"].ToString() + sqlReader["n.TIPO_SUCURSAL"].ToString() + sqlReader["n.TRANSACCION_ID"].ToString() + sqlReader["n.FECHA_PROCESO"].ToString() + sqlReader["n.TIPO_OPERACION"].ToString() + "\t\t\t\t\t" + sqlReader["CIERRE_SUCURSAL"].ToString() + sqlReader["CREDITO"].ToString());
                }
            }

            sqlReader.Close();
            comm.Connection.Close();

            ColorOk("Los datos se registraron correctamente.");
        }


        static void ColorProceso(string value)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); 
                                                                        
            Console.ResetColor();
        }



        static void ColorOk(string value)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); 
            Console.ResetColor();
        }

      
        static void ColorWarn(string value)
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); 
            Console.ResetColor();
        }

        static void ColorError(string value)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); 
            Console.ResetColor();
        }


        public class Algo
        {


            private string CIERRE_BANCO { get; set; }
            private string BANCO { get; set; }
            private string CIERRE_SUCURSAL { get; set; }
            private string SUCURSAL { get; set; }
            private string FECHA_CIERRE { get; set; }
        }

        // -------------------- 2 --------------------------
        public class Algo1
        {

            private string TRANSACCION_ID { get; set; }
            private string NUMERO_CHEQUE { get; set; }
            private string BANCO_CHEQUE { get; set; }
            private string SUCURSAL_CHEQUE { get; set; }
        }

        // -------------------- 3 --------------------------
        public class Algo2
        {

            private string CIERRE_BANCO { get; set; }
            private string BANCO { get; set; }
            private string TRANSACCION_ID { get; set; }
            private string IMPUESTO { get; set; }
            private string MONEDA { get; set; }
            private string CREDITO { get; set; }
            private string COMISION_X_TRAN { get; set; }
            private string COMISION_RECAUD { get; set; }
            private string IVA { get; set; }
            private string RETENCION_IVA { get; set; }
        }

        // -------------------- 4 --------------------------
        public class Algo3
        {

            private string TRANSACCION_ID { get; set; }
            private string BANCO { get; set; }
            private string CIERRE_BANCO { get; set; }
            private string SUCURSAL { get; set; }
            private string TIPO_SUCURSAL { get; set; }
            private string TRANSACCION { get; set; }
            private string FECHA_PROCESO { get; set; }
            private string TIPO_OPERACION { get; set; }
            private string Formulario { get; set; }
            private string Cuit { get; set; }
            private string USUARIO { get; set; }
            private string PUESTO { get; set; }
            private string FECHA_ANULACION { get; set; }
            private string FORMA_PAGO { get; set; }
            private string CIERRE_SUCURSAL { get; set; }
        }

        // -------------------- 5 --------------------------
        public class Algo4
        {

            private string TRANSACCION_ID { get; set; }
            private string IMPUESTO { get; set; }
        }








    }





}




